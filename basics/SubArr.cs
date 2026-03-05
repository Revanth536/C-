using System;

class main {
    static void Main() {
        int n = ReadInt();
        int[] a = new int[n];
        
        for (int i = 0; i < n; i++)
            a[i] = ReadInt();

        int count = 0;
        for (int i = 0; i < n; i++) {
            int result = 0;
            for (int j = i; j < n; j++) {
                result += a[j];
                if (result < 0) count++;
            }
        }
        Console.WriteLine(count);
    }

    // Helper to read integers directly from the input stream
    static int ReadInt() {
        int c = Console.Read();
        while (c != -1 && c <= 32) c = Console.Read(); // Skip whitespace
        if (c == -1) return 0;
        
        int sign = 1;
        if (c == '-') {
            sign = -1;
            c = Console.Read();
        }

        int res = 0;
        while (c >= '0' && c <= '9') {
            res = res * 10 + (c - '0');
            c = Console.Read();
        }
        return res * sign;
    }
}
