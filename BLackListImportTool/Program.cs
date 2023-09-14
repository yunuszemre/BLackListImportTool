using BLackListImportTool.DataModels;
using BLackListImportTool.ModelProd;
//using BLackListImportTool.TMS_Models;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using static System.Net.WebRequestMethods;

internal class Program
{
    private static void Main(string[] args)
    {
        var localConext = new BlackListKGSContext();
        var blk = localConext.BlacklisTkgs.ToList();

        var tmsContext = new cl_tmsContext();
        var blkList = tmsContext.AccountCarrierBlacklists.Include(x => x.City).Include(x => x.Town).ToList();
        var towns = tmsContext.Towns.ToList();
        int colNumber = 1;
        int rowNumber = 1;

        List<Town> findedTownNames = new List<Town>();

        foreach (var town in blk)
        {
            foreach (var item in towns)
            {
                Town findedTown = null;
                if (town.İlçeAdı == null)
                {
                    continue;
                }
                else
                {
                    if (town.CityId != item.CityId)
                    {
                        continue;
                    }
                    findedTown = FindMostSimilarString(town, towns,ref colNumber,ref rowNumber);
                    if (findedTown != null)
                    {

                        findedTownNames.Add(findedTown);
                    }
                }

            }
        }
        foreach (var item in findedTownNames)
        {
            AccountCarrierBlacklist acc = new()
            {
                AccountId = 5,
                LocationId = 52,
                CarrierId = 17,
                CityId = item.CityId,
                TownId = item.TownId,
                CountryId = 1,
                CreatedDate = DateTime.Now,
                CreateUserIdentityId = 1,
                RecordStatusId = 1,

            };
            bool isDbContains = tmsContext.AccountCarrierBlacklists.Any(x => x.AccountId == acc.AccountId && x.LocationId == acc.LocationId && x.CarrierId == acc.CarrierId && x.CityId == acc.CityId && x.TownId == acc.TownId);
            if (isDbContains)
            {
                Console.WriteLine($"Veri zaten mevcut");
            }
            if (!isDbContains)
            {
                tmsContext.AccountCarrierBlacklists.Add(acc);
                tmsContext.SaveChanges();
            }
        }

        Console.WriteLine("Hello, World!");
    }
    static double Jaro(string s1, string s2)
    {
        if (s1 == null || s2 == null)
            return 0;

        int s1Len = s1.Length, s2Len = s2.Length;

        if (s1Len == 0 || s2Len == 0)
            return 0;

        int matchDistance = Math.Max(s1Len, s2Len) / 2 - 1;
        bool[] s1Matches = new bool[s1Len];
        bool[] s2Matches = new bool[s2Len];

        int matches = 0;
        int transpositions = 0;

        for (int i = 0; i < s1Len; i++)
        {
            int start = Math.Max(0, i - matchDistance);
            int end = Math.Min(i + matchDistance + 1, s2Len);

            for (int j = start; j < end; j++)
            {
                if (s2Matches[j]) continue;
                if (s1[i] != s2[j]) continue;

                s1Matches[i] = true;
                s2Matches[j] = true;
                matches++;
                break;
            }
        }

        if (matches == 0) return 0;

        int k = 0;
        for (int i = 0; i < s1Len; i++)
        {
            if (!s1Matches[i]) continue;

            while (!s2Matches[k]) k++;

            if (s1[i] != s2[k]) transpositions++;
            k++;
        }

        return ((double)matches / s1Len + (double)matches / s2Len + (double)(matches - transpositions / 2.0) / matches) / 3.0;
    }

    static double JaroWinkler(string s1, string s2, double p = 0.1)
    {

        double jaro = Jaro(s1.ToUpper(), s2);
        int prefix = 0;
        while (prefix < s1.ToUpper().Length && prefix < s2.Length && s1.ToUpper()[prefix] == s2[prefix])
        {
            prefix++;
        }
        return jaro + prefix * p * (1 - jaro);
    }

    static Town FindMostSimilarString(BlacklisTkg s1, List<Town> stringArray, ref int colNumber, ref int rowNumber)
    {


        Town findedTown = null;
        if (stringArray == null || stringArray.Count == 0)
            return null;
        string mostSimilarString = stringArray[0].Code;
        double highestSimilarity = JaroWinkler(s1.İlçeAdı.ToUpper(), mostSimilarString);
        
        for (int i = 0; i < stringArray.Count; i++)
        {


            double similarity = JaroWinkler(s1.İlçeAdı.ToUpper(), stringArray[i].Code);

            if (similarity > highestSimilarity)
            {
                mostSimilarString = stringArray[i].Code;
                highestSimilarity = similarity;
                if (highestSimilarity >= 0.92)
                {
                    Console.WriteLine($"Aranan İlçe: {s1.İlçeAdı,-10} Eşleşen İlçe: {stringArray[i].Code,-20} Eşleşme Oranı: {highestSimilarity * 100,-10}");
                    findedTown = stringArray[i];
                    return findedTown;

                }
                else
                {

                    Console.WriteLine($"Aranan İlçe: {s1.İlçeAdı,-10} Eşleşen İlçe: {stringArray[i].Code,-20} Eşleşme Oranı: {highestSimilarity * 100,-10}");
                    if (highestSimilarity > 0.8999 && highestSimilarity < 91.999)
                    {
                        string path = @"C:\\Users\\enoca-yunus\\source\\repos\\BLackListImportTool\\BLackListImportTool\\bin\\Debug\\net6.0\\Eşleşmeyenlerr.txt";

                        try
                        {
                            // FileStream kullanarak dosyayı açın (FileMode.Append kullanarak dosyaya ekleme yapabilirsiniz)
                            using (FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write))
                            {
                                // StreamWriter kullanarak dosyaya yazma işlemi yapın
                                using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
                                {
                                    // Dosyaya eklemek istediğiniz verileri yazın
                                    streamWriter.WriteLine($"Bulunan Şehir Id: {stringArray[i].CityId} Eşleşme Oranı: {highestSimilarity * 100} Aranan İlçe: {s1.İlçeAdı} Bulunan İlçe: {stringArray[i].Code}");


                                    // StreamWriter nesnesini kapatın (bu, dosyanın kaydedilmesini sağlar)
                                    streamWriter.Close();
                                }
                            }

                            Console.WriteLine("Dosyaya ekleme işlemi tamamlandı.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Hata oluştu: " + ex.Message);
                        }
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                        using (var package = new ExcelPackage(new FileInfo(@"C:\\Users\\enoca-yunus\\source\\repos\\BLackListImportTool\\BLackListImportTool\\bin\\Debug\\net6.0\\Eşleşmeyenler.xlsx")))
                        {

                            // Yeni bir çalışma sayfası oluşturun
                            var worksheet = package.Workbook.Worksheets[0];
                            var s = $"Bulunan Şehir Id: {stringArray[i].CityId} Eşleşme Oranı: {highestSimilarity * 100} Aranan İlçe: {s1.İlçeAdı} Bulunan İlçe: {stringArray[i].Code}";
                            // Verileri hücrelere ekleyin
                            worksheet.Cells[rowNumber, colNumber].Value = stringArray[i].CityId;
                            colNumber++;
                            worksheet.Cells[rowNumber, colNumber].Value = $"Eşleşme Oranı: {highestSimilarity * 100}";
                            colNumber++;
                            worksheet.Cells[rowNumber, colNumber].Value = $"{s1.İlçeAdı}";
                            colNumber++;
                            worksheet.Cells[rowNumber, colNumber].Value = $"{stringArray[i].Code}";
                            rowNumber++;
                            colNumber = 1;
                            Console.WriteLine("\n\nEXCELL E EKLENDİ\n\n");
                            // Excel dosyasını kaydedin


                            package.Save();


                            //}
                        }
                    }
                }
               
            }
            //findedTown = stringArray[i];


        }

        return null;
    }

}

