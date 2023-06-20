using System;

public class ElliottWave
{
    public static void Main()
    {
        // Example usage
        int[] positiveWave = { 1, 2, 3, 4, 3, 2, 1, 2, 3, 4, 5, 4, 3, 2 };

        // Negative Elliott wave
        int[] negativeWave = { 5, 4, 3, 2, 3, 4, 5, 4, 3, 2, 1, 2, 3, 4 };

        // Array containing both positive and negative Elliott waves
        int[][] waves = { positiveWave, negativeWave };

        foreach (int[] wave in waves)
        {
            bool isElliottWave = IsElliottWave(wave);
            Console.WriteLine("Is it an Elliott wave? " + isElliottWave + " (Length: " + wave.Length + ") ");
        }
    }

    public static bool IsElliottWave(int[] data)
    {
        int n = data.Length;

        if (n < 8)
            return false;

        bool isImpulse = IsImpulseWave(data);
        bool isCorrective = IsCorrectiveWave(data);

        return isImpulse || isCorrective;
    }

    public static bool IsImpulseWave(int[] data)
    {
        int n = data.Length;

        // Check if the wave has the correct impulse pattern
        for (int i = 0; i < n - 4; i++)
        {
            if (data[i + 1] > data[i] && data[i + 2] > data[i + 1] && data[i + 3] > data[i + 2] && data[i + 4] > data[i + 3])
            {
                // Wave has the impulse pattern
                return true;
            }
        }

        return false;
    }

    public static bool IsCorrectiveWave(int[] data)
    {
        int n = data.Length;

        // Check if the wave has the correct corrective pattern
        for (int i = 0; i < n - 4; i++)
        {
            if (data[i + 1] < data[i] && data[i + 2] > data[i + 1] && data[i + 3] < data[i + 2] && data[i + 4] > data[i + 3])
            {
                // Wave has the corrective pattern
                return true;
            }
        }

        return false;
    }
}
