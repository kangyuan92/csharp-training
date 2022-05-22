// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Assignment2
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //1.
            Console.WriteLine("********* 1. Copying an Array ********");
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            copyArray(arr1);

            //2.
            Console.WriteLine("********* 2. Manage items ********");
            manageItems();

            //3.
            Console.WriteLine("********* 3. Prime ********");
            Console.WriteLine(String.Join(",", findPrimesInRange(3,9)));

            //4.
            Console.WriteLine("********* 4. Rotate Array********");
            rotateArray();


            //5. 
            Console.WriteLine("********* 5. Longest Sequence ********");
            
            Boolean stop = false;
            while (!stop)
            {
                Console.WriteLine("Enter an array or enter END to stop");
                stop = longestSequence();
            }

            //6.
            Console.WriteLine("********* 7. Most Sequence ********");
            stop = false;
            while (!stop)
            {
                Console.WriteLine("Enter an array or enter END to stop");
                stop = mostFrequency();
            }

            //Practice Strings
            //1.
            Console.WriteLine("********* 1. Reverse String ********");
            stop = false;
            while (!stop)
            {
                Console.WriteLine("Enter an array or enter END to stop");
                stop = reverseString();
            }
        }

        static Boolean reverseString()
        {
            string inputString = Console.ReadLine();

            if (inputString.Equals("END")) return true;

            char[] inputArr = inputString.ToCharArray();
            Array.Reverse(inputArr);

            Console.WriteLine(String.Join("", inputArr));

            return false;
        }


        static void copyArray(int[] arr1)
        {
            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i] + " " + arr2[i]);
            }
        }

        static void manageItems()
        {
            Boolean end = false;
            List<String> items = new List<String>();
            while (!end)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)) or enter END to end the loop:");
                String input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    end = true;
                    continue;
                }


                if (input.StartsWith("+"))
                {
                    input = input.Substring(1);
                    items.Add(input);
                }
                else if (input.StartsWith("-"))
                {
                    input = input.Substring(1);
                    items.Remove(input);
                }
                else if (input.StartsWith("--"))
                {
                    items.Clear();
                }

                Console.WriteLine("Current item list: ");
                Console.WriteLine(String.Join(",", items));
            }
        }

        static int[] findPrimesInRange(int startNum, int endNum)
        {
            int[] ans;
            List<int> primeNums = new List<int>();

            for(int i = startNum; i <= endNum; i++)
            {   
                if(i%2 == 0) continue;

                Boolean isPrime = true;
                for(int j = 3; j <= i/2; j=j+2)
                {
                    if (i % j == 0) {
                        isPrime = false; 
                        break;
                    }
                }

                if(isPrime) primeNums.Add(i);
            }

            ans = primeNums.ToArray();
            return ans;
        }

        static void rotateArray()
        {
            string inputString = Console.ReadLine();
            string[] inputArr = inputString.Split(' ');
            int[] arr = new int[inputArr.Length];

            int k = int.Parse(Console.ReadLine());
            int n = inputArr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(inputArr[i]);
            }

            Console.WriteLine(String.Join(" ", arr));


            int[] sumArr = new int[inputArr.Length];
            Array.Fill(sumArr, 0);


            for (int r = 1; r <= k; r++)
            {
                for (int l = 0; l < arr.Length; l++)
                {
                    sumArr[(r + l) % n] += arr[l];
                }
            }


            Console.WriteLine(String.Join(" ", sumArr));
        }

        static Boolean longestSequence()
        {
            string inputString = Console.ReadLine();

            if (inputString.Equals("END")) return true;

            string[] inputArr = inputString.Split(' ');
            int[] arr = new int[inputArr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(inputArr[i]);
            }

            //Console.WriteLine(String.Join(" ", arr));

            int n = arr.Length;

            int ans_left = 0;
            int ans_right = 0;

            int right = 0;
            int left = 0;
            while (right < n)
            {
                if(arr[right] == arr[left])
                {
                    right++;
                    continue;
                }

                if(right-left > ans_right - left)
                {
                    ans_left = left;
                    ans_right = right;
                }

                left = right;
            }

            if (right - left > ans_right - ans_left)
            {
                ans_left = left;
                ans_right = right;
            }

            int[] ans = new int[ans_right - ans_left];

            for(int i = 0; i<ans.Length; i++)
            {
                ans[i] = arr[ans_left];
                ans_left++;
            }

            Console.WriteLine(String.Join(" ", ans));

            return false;
        }

        static Boolean mostFrequency()
        {
            string inputString = Console.ReadLine();

            if (inputString.Equals("END")) return true;

            string[] inputArr = inputString.Split(' ');
            int[] arr = new int[inputArr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(inputArr[i]);
            }

            var dict = new Dictionary<int, int>(){};
            int cur_max = -1;
            int cur_count = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], 1);
                    if (cur_count < 1)
                    {
                        cur_max = arr[i];
                    }
                }
                dict[arr[i]] += 1;

                if(cur_count < dict[arr[i]])
                {
                    cur_count = dict[arr[i]];
                    cur_max = arr[i];
                }
            }

            Console.WriteLine(cur_max);

            return false;
        }
    }
}

