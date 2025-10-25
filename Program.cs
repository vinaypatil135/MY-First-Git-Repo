Console.WriteLine("enter amstrong no");
int num = Convert.ToInt32(Console.ReadLine()),sum = 0, temp = num;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit * digit * digit; // For 3-digit numbers
            temp /= 10;
        }

        if (sum == num)
            Console.WriteLine($"{num} is an Armstrong number.");
        else
            Console.WriteLine($"{num} is not an Armstrong number.");

