namespace RotateAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int[] nums = new int[100];
            var line = Console.ReadLine().Split(' ');
            foreach (var item in line)
            {
                nums[n++] = int.Parse(item);
            }

            int[] rotated = new int[n];
            int[] sum = new int[n];

            int rotate = int.Parse(Console.ReadLine());
            do
            {
                rotated[0] = nums[n - 1];
                for (int i = 0; i < n - 1; i++) rotated[i + 1] = nums[i];

                for (int i = 0; i < n; i++)
                {
                    nums[i] = rotated[i];
                }

                for (int i = 0; i < n; i++)
                {
                    sum[i] += rotated[i];
                }

                rotate--;
            }
            while (rotate >= 1);

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", sum[i]);
            }
        }
    }
}