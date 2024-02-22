using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

public class ObjectSerializer
{
    // Méthode pour sérialiser un objet dans un fichier
    public static async Task SerializeToFile<T>(T obj, string filePath)
    {
        try
        {
            // Sérialisation de l'objet en JSON
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(obj, options);

            // Écriture dans le fichier
            await File.WriteAllTextAsync(filePath, jsonString);
            Console.WriteLine("Objet sérialisé avec succès.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur lors de la sérialisation : {ex.Message}");
        }
    }

    // Méthode pour désérialiser un objet depuis un fichier
    public static async Task<T> DeserializeFromFile<T>(string filePath)
    {
        try
        {
            // Lecture du contenu du fichier
            string jsonString = await File.ReadAllTextAsync(filePath);

            // Désérialisation du JSON en objet
            return JsonSerializer.Deserialize<T>(jsonString);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur lors de la désérialisation : {ex.Message}");
            return default;
        }
    }
}
