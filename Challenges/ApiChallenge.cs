using System.Collections;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Challenges;

public record ChallengeJson
{
    [JsonPropertyName("challenger")]
    public required string Challenger { get; set; }

    [JsonPropertyName("encrypted_path")]
    public required string EncryptedPath { get; set; }

    [JsonPropertyName("encryption_method")]
    public required string EncryptionMethod { get; set; }

    [JsonPropertyName("expires_in")]
    public required string ExpiresIn { get; set; }

    [JsonPropertyName("hint")]
    public required string Hint { get; set; }

    [JsonPropertyName("instructions")]
    public required string Instructions { get; set; }

    [JsonPropertyName("level")]
    public required int Level { get; set; }
}

public class SolveTest
{
    public static async Task Attempt()
    {
        string origin = "";
        string path = "";

        HttpClient client = new() { BaseAddress = new Uri(origin) };

        ChallengeJson json = await GetNextJson(client, path);
        path = UnencryptThePath(json);

        json = await GetNextJson(client, path);
        path = UnencryptThePath(json);

        json = await GetNextJson(client, path);
        path = UnencryptThePath(json);

        json = await GetNextJson(client, path);
        path = UnencryptThePath(json);

        json = await GetNextJson(client, path);
        path = UnencryptThePath(json);

        json = await GetNextJson(client, path);
        path = UnencryptThePath(json);

    }

    private static async Task<ChallengeJson> GetNextJson(HttpClient client, string path)
    {
        HttpResponseMessage response = await client.GetAsync(path);

        string content = await response.Content.ReadAsStringAsync();
        try
        {
            return JsonSerializer.Deserialize<ChallengeJson>(content)!;
        }
        catch
        {
            throw new ApplicationException("oh no ");
        }
        
    }

    private static string UnencryptThePath(ChallengeJson data)
    {
        string encryptedPath = data.EncryptedPath;

        if (data.EncryptionMethod == "nothing")
        {
            return encryptedPath;
        }
        else if (data.EncryptionMethod == "converted to a JSON array of ASCII values")
        {
            return UnencryptStringWithJsonArray(data.EncryptedPath);
        }
        else if (data.EncryptionMethod == "swapped every pair of characters")
        {
            return UnencryptSwappedEveryPair(data.EncryptedPath);
        }
        else if (data.EncryptionMethod.Contains("added") && data.EncryptionMethod.Contains("to ASCII value of each character"))
        {
            int numThatWasSubtracted = WhatWasSubtracted(data.EncryptionMethod) * -1;
            // also could be "added -1 to ASCII value of each character"
            return UnencryptByAddingNum(data.EncryptedPath, numThatWasSubtracted);
        }
        // hex decoded, encrypted with XOR, hex encoded again. key: secret
        else if (data.EncryptionMethod.Contains("hex decoded, encrypted with XOR"))
        {
            string hexKey = ExtractTheKey(data.EncryptionMethod);

            return UnencryptXorAndHex(data.EncryptedPath, hexKey);
        }
        else
        {



            // debug breakpoint here to look at what is going on
            return "";
        }
    }

    // undo this:
    // hex decoded, encrypted with XOR, hex encoded again. key: secret
    // 1. hex decode
    // 2. xor with key
    // 3. hex encode
    // the result of that looks like this: fa616875178247292b0301f7fe7ff1
    // so that value needs to be converted to bits, xored with the key,
    // and converted back to hexadecimal?
    public static string UnencryptXorAndHex(string encryptedPath, string hexKey)
    {
        byte[] key = Encoding.ASCII.GetBytes(hexKey);
        BitArray keyAsBits = new(key);

        encryptedPath = encryptedPath.Substring(5);
        
        byte[] decodedFromHex = Convert.FromHexString(encryptedPath);
        BitArray decodedFromHexAsBits = new(decodedFromHex);

        keyAsBits.Length = decodedFromHexAsBits.Length;

        BitArray decodedFromXor = decodedFromHexAsBits.Xor(keyAsBits);

        byte[] asBytesAgain = new byte[16];
    
        decodedFromXor.CopyTo(asBytesAgain, 0);

        string asString = BitConverter.ToString(asBytesAgain);
        
        string[] hexStrings = asString.Split("-");

        string result = "";

        foreach(string hexValue in hexStrings)
        {
            result += hexValue;
        }

        return "task_" + result.ToLower();
    }

    public static string UnencryptByAddingNum(string input, int num)
    {
        string middle = input[5..];

        char[] chars = new char[middle.Length];

        for (int i = 0; i < middle.Length; i += 1)
        {
            int c = middle[i];

            int with10added = c + num;

            chars[i] = (char)with10added;
        }

        string result = new(chars);

        return "task_" + result;
    }

    public static string UnencryptStringWithJsonArray(string input)
    {
        string middle = input[6..^1];

        List<string> asciiInts = new(middle.Split(","));

        char[] chars = new char[asciiInts.Count];

        int i = 0;
        foreach(string asciiInt in asciiInts)
        {
            int asInt = int.Parse(asciiInt);

            char asChar = (char)asInt;
            chars[i] = asChar;
            i += 1;
        }

        string result = new(chars);

        return "task_" + result;
    }

    public static string UnencryptSwappedEveryPair(string input)
    {
        string middle = input[5..];

        char[] middleChars = new char[middle.Length];

        for (int i = 0; i < middle.Length; i += 1)
        {
            middleChars[i] = middle[i];
        }

        for (int i = 0; i + 1 < middle.Length; i += 2)
        {
            char temp = middleChars[i];
            middleChars[i] = middleChars[i + 1];
            middleChars[i + 1] = temp;
        }

        string result = new(middleChars);

        return "task_" + result;
    }

    public static int WhatWasSubtracted(string input)
    {
        int numberStartPosition = 6;

        for (int i = numberStartPosition; i < input.Length; i += 1)
        {
            char c = input[i];

            if (c == ' ')
            {
                string num = input.Substring(numberStartPosition, i - numberStartPosition);

                int asInt = int.Parse(num);

                return asInt;
            }
        }

        throw new ApplicationException();
    }

    public static string ExtractTheKey(string input)
    {
        return input.Substring("hex decoded, encrypted with XOR, hex encoded again. key: ".Length);
    }
}