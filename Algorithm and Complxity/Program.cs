using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Offcial_Algorithm_Assesment_2018
{
    class Program
    {
        public static string Choice1, Choice2;
        public static bool Option = true;
        static void Main(string[] args)
        {

            string Decision;
            double[] OriginalArr = new double[128];
            double[] SortedArr = new double[128];
            int OverallS = 128;
            double key;

            //This is the mainly the user interface area which allows the user to pick what file that they would like to view.

            Console.WriteLine("Hello and welcome\n");

            Console.WriteLine("Which file would you like to load?\n");
            Console.WriteLine("Press '1' to open Change_128 file");
            Console.WriteLine("Press '2' to open Open_128 file");
            Console.WriteLine("Press '3' to open Close_128 file");
            Console.WriteLine("Press '4' to open Low_128 file");
            Console.WriteLine("Press '5' to open High_128 file");
            Console.WriteLine("Press '6' to open Change_256 file");
            Console.WriteLine("Press '7' to open Close_256 file");
            Console.WriteLine("Press '8' to open Open_256 file");
            Console.WriteLine("Press '9' to open High_256 file");
            Console.WriteLine("Press '10' to open Low_256_file");
            Console.WriteLine("Press '11' to open Low_1024_file");
            Console.WriteLine("Press '12' to open High_1024_file");
            Console.WriteLine("Press '13' to open Change_1024_file");
            Console.WriteLine("Press '14' to open Close_1024_file");
            Console.WriteLine("Press '15' to open Open_1024_file");
            Decision = Console.ReadLine();


            switch (Decision) //This switch case allows the user to load a selected file of there choice from the data file.
            {
                case "1":
                    Console.WriteLine("\nYou selected a Change_128 file\n");
                    Decision = "Change_128";
                    break;
                case "2":
                    Console.WriteLine("\nYou selected a Open_128 file\n");
                    Decision = "Open_128";
                    break;
                case "3":
                    Console.WriteLine("\nYou selected a Close_128 file\n");
                    Decision = "Close_128";
                    break;
                case "4":
                    Console.WriteLine("\nYou selected a Low_128 file\n");
                    Decision = "Low_128";
                    break;
                case "5":
                    Console.WriteLine("\nYou selected a High_128 file\n");
                    Decision = "High_128";
                    break;
                case "6":
                    Console.WriteLine("\nYou selected a Change_256 file\n");
                    Decision = "Change_256";
                    OverallS = 256;
                    break;
                case "7":
                    Console.WriteLine("\nYou selected a Close_256 file\n");
                    Decision = "Close_256";
                    OverallS = 256;
                    break;
                case "8":
                    Console.WriteLine("\nYou selected a Open_256 file\n");
                    Decision = "Open_256";
                    OverallS = 256;
                    break;
                case "9":
                    Console.WriteLine("\nYou selected a High_256 file\n");
                    Decision = "High_256";
                    OverallS = 256;
                    break;
                case "10":
                    Console.WriteLine("\nYou selected a Low_256 file\n");
                    Decision = "Low_256";
                    OverallS = 256;
                    break;
                case "11":
                    Console.WriteLine("\nYou selected a Low_1024 file\n");
                    Decision = "Low_1024";
                    OverallS = 1024;
                    break;
                case "12":
                    Console.WriteLine("\nYou selected a High_1024 file\n");
                    Decision = "High_1024";
                    OverallS = 1024;
                    break;
                case "13":
                    Console.WriteLine("\nYou selected a Change_1024 file\n");
                    Decision = "Change_1024";
                    OverallS = 1024;
                    break;
                case "14":
                    Console.WriteLine("\nYou selected a Close_1024 file\n");
                    Decision = "Close_1024";
                    OverallS = 1024;
                    break;
                case "15":
                    Console.WriteLine("\nYou selected a Open_1024 file\n");
                    Decision = "Open_1024";
                    OverallS = 1024;
                    break;
                default:
                    Console.WriteLine("\nThis input is invalid");
                    break;
            }

            OriginalArr = FileName(Decision, OverallS);
            Console.WriteLine("What sort algorithm would you like to run?\n 1) Use Insertion sorter\n 2) Use Quick sort\n 3) Use Merge Sort\n 4) Use Bubble Sort\n"); //The types of sorting algorithms are being displayed here for the user
            Choice1 = Console.ReadLine();
            Console.WriteLine("What would you now like to do with the algorthim?\n 1) Run the code in ascending order\n 2) Run the in descending order\n "); //This allows the user to choose if they would rather run the algorithm in ascending or descending order.
            string ToDo = Console.ReadLine();
            switch (ToDo) //This switch statement clarifys the decison that the user chose of running in ascending or descending order.
            {
                case "1":
                    Console.WriteLine("You have chosen to run the code in ascending order");
                    Option = true;
                    break;
                case "2":
                    Console.WriteLine("You have chosen to run the code in descending order");
                    Option = false;
                    break;
            }
            switch (Choice1) // This case allows the user to chose what type of algorithm they run. 
            {
                case "1":
                    Console.WriteLine("You have chosen Insertion sort.");
                    if (Option == true)
                    {
                        SortedArr = InsertionSorterAscending.DoInsertionSortAscending(OriginalArr); //The sorting algorithm for insertion has been called here so that if the user selects insertion ascending the algorithm will run.
                    }
                    else
                        SortedArr = InsertionSorterDescending.DoInsertionSortDescending(OriginalArr); //The sorting algorithm for insertion has been called here so that if the user selects insertion descending the algorithm will run.
                    break;
                case "2":
                    Console.WriteLine("You have chosen Qucik sort.");
                    if (Option == true)
                    {
                        SortedArr = QuicksortAscending.DoQuickSortAscending(OriginalArr, 0, OriginalArr.Length);
                        Console.WriteLine("\nThe number of steps that occured was {0}\n", QuicksortAscending.count); //The count used here counts the number of steps that the algorithm took to occur.
                    }
                    else
                    {
                        SortedArr = QuickSortDescending.DoQuickSortDescending(OriginalArr, 0, OriginalArr.Length);
                        Console.WriteLine("\nThe number of steps that occured was {0}\n", QuickSortDescending.count);//The count used here counts the number of steps that the algorithm took to occur.
                    }
                    break;
                case "3":
                    Console.WriteLine("You have chose Merge sort");
                    if (Option == true)
                    {
                        SortedArr = MergesortAscending.DoMergeSortAscending(OriginalArr);
                        Console.WriteLine("\nThe number of steps that occured was {0}\n", MergesortAscending.count);//The count used here counts the number of steps that the algorithm took to occur.
                    }

                    else
                    {
                        SortedArr = MergesortDescending.DoMergeSortDescending(OriginalArr);
                        Console.WriteLine("\nThe number of steps that occured was {0}\n", MergesortDescending.count);//The count used here counts the number of steps that the algorithm took to occur.
                    }


                    break;
                case "4":
                    Console.WriteLine("You have chose Bubble Sort");
                    if (Option == true)
                    {
                        SortedArr = BubbleSortAscending.DoBubbleSortAscending(OriginalArr, OriginalArr.Length);
                        Console.WriteLine("\nThe number of steps that occured was {0}\n", BubbleSortAscending.count);//The count used here counts the number of steps that the algorithm took to occur.
                    }
                    else
                    {
                        SortedArr = BubbleSortDescending.DoBubbleSortDescending(OriginalArr, OriginalArr.Length);
                        Console.WriteLine("\nThe number of steps that occured was {0}\n", BubbleSortDescending.count);//The count used here counts the number of steps that the algorithm took to occur.
                    }
                    break;

            }

            switch (Choice2) //This switch case is for the Search algorithms 
            {
                case "1":
                    Console.WriteLine("You have chose Binary Search");
                    if (Option == true)

                        SortedArr = BinarySearchAscending.DoBinarySearchAscending(OriginalArr, 0, OriginalArr.Length, OriginalArr.Length);
                    else
                        SortedArr = BinarySearchDescending.DoBinarySearchDescending(OriginalArr, 0, OriginalArr.Length, OriginalArr.Length);
                    break;

                case "2":
                    Console.WriteLine("You have chose Interpolation Search");
                    if (Option == true)

                        SortedArr = InterpolationSearchAscending.DoIntSearch(OriginalArr, 0);
                    else
                        SortedArr = BinarySearchDescending.DoBinarySearchDescending(OriginalArr, 0, OriginalArr.Length, OriginalArr.Length);
                    break;
            }
            foreach (double Test in SortedArr)
            {
                Console.WriteLine(Test);// This line of code makes sure that my decison that is chosen is displayed when called.
            }
            Console.ReadKey();

            Console.WriteLine("What search algorithm would you like to run?\n 1) Use Binary Search\n 2) Interpolation search");
            Choice2 = Console.ReadLine();

            Console.WriteLine("What number would you like to search?");
            key = Convert.ToDouble(Console.ReadLine());


            switch (Choice2)
            {
                case "1":
                    Console.WriteLine("You have chose Binary Search");
                    if (Option == true)

                        SortedArr = BinarySearchAscending.DoBinarySearchAscending(OriginalArr, 0, OriginalArr.Length, key);
                    else
                        SortedArr = BinarySearchDescending.DoBinarySearchDescending(OriginalArr, 0, OriginalArr.Length, key);
                    break;

                case "2":
                    Console.WriteLine("You have chose Interpolation Search");
                    if (Option == true)

                        SortedArr = InterpolationSearchAscending.DoIntSearch(OriginalArr, key);
                    else
                        SortedArr = InterpolationSearchDescending.DoIntSearchDec(OriginalArr, 0);
                    break;
            }

            foreach (int val in SortedArr)
            {
                if (val != 0)
                {
                    Console.WriteLine(val);
                }
            }
            Console.ReadKey();
        }
        public static double[] FileName(string FileName, int Size)
        {
            int count = 0;
            double value;
            string line;
            double[] arr = new double[Size];

            System.IO.StreamReader File = new System.IO.StreamReader(@FileName + ".txt"); //The file which is selcted is loaded from this location
            while ((line = File.ReadLine()) != null)
            {
                value = Convert.ToDouble(line); 
                arr[count] = value;
                count++;
            }

            return arr;

        }
    }
    public static class InsertionSorterDescending
    {
        public static double[] DoInsertionSortDescending(this double[] numbers)
        {
            int milliseconds = 550;
            Thread.Sleep(milliseconds);
            int count = 0;
            for (int i = 1; i < numbers.Length; i++)
            {

                for (int j = i; j > 0 && numbers[j - 1] < numbers[j]; j--) // Change the ">" to "<" to make the insertion sort show in descending order instead of ascending order.
                {
                    numbers.SwapValuesIndices(j, j - 1);
                    count++;
                }
            }
            Thread.Sleep(milliseconds);
            Console.WriteLine("\nThe number of steps is {0}\n", count);
            return numbers;
        }

    }
    public static class InsertionSorterAscending
    {
        public static double[] DoInsertionSortAscending(this double[] numbers)
        {
            int count = 0;
            int milliseconds = 550;
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = i; j > 0 && numbers[j - 1] > numbers[j]; j--) // Change the ">" to "<" to make the insertion sort show in descending order instead of ascending order.
                {
                    numbers.SwapValuesIndices(j, j - 1);
                    count++;
                }
            }
            Thread.Sleep(milliseconds);
            Console.WriteLine("\nThe number of steps is {0}\n", count);
            return numbers;
        }
        public static void quickSort(int[] arr, int i, int j)
        {
            if (i < j)
            {
                int pos = partition(arr, i, j);
                quickSort(arr, i, pos - 1);
                quickSort(arr, pos + 1, j);
            }
        }
        private static int partition(int[] arr, int i, int j)
        {
            int pivot = arr[j];
            int small = i - 1;

            for (int k = i; k < j; k++)
            {
                if (arr[k] <= pivot)
                {
                    small++;
                    swap(arr, k, small);
                }
            }
            swap(arr, j, small + 1);
            Console.WriteLine("Pivot = " + arr[small + 1]);
            Console.WriteLine(String.Join(" ", arr));
            return small + 1;
        }
        private static void swap(int[] arr, int k, int small)
        {
            int temp;
            temp = arr[k];
            arr[k] = arr[small];
            arr[small] = temp;
        }
    }
    public static class Swapper
    {
        public static void SwapValuesIndices<T>(this T[] objects, int i, int j)
        {
            T temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }

    }
    public static class QuicksortAscending
    {
        public static int count = 0;
        public static double[] DoQuickSortAscending(double[] arr, int left, int right)
        {
            int i, j;
            double temp;
            double pivot = arr[right - 1];
            int small = left - 1;

            i = left;
            j = right;
            pivot = arr[(left + right) / 2];

            do
            {
                while ((arr[i] < pivot) && (i < right)) i++;
                while ((pivot < arr[j]) && (j > left)) j--;

                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j - 1];
                    arr[j] = temp;
                    i++;
                    j--;
                    count++;
                }
            } while (i <= j);

            if (left < j) DoQuickSortAscending(arr, left, j);
            if (i < right) DoQuickSortAscending(arr, i, right);
            Console.WriteLine("The amount of steps that occured is {0}\n", count);
            return arr;
        }

    }
    public static class QuickSortDescending 
    {
        public static int count = 0; //The universal count so that the steps that occur can be counted.
        public static double[] DoQuickSortDescending(double[] arr, int left, int right) 
        {
            int i, j;
            double temp;
            double pivot = arr[right - 1];
            int small = left - 1;

            i = left;
            j = right;
            pivot = arr[(left + right) / 2];

            do
            {
                while ((arr[i] > pivot) && (i < right)) i++;
                while ((pivot > arr[j - 1]) && (j > left)) j--;

                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j - 1];
                    arr[j - 1] = temp;
                    i++;
                    j--;
                    count++;
                }
            }
            while (i <= j);
            if (left < j) DoQuickSortDescending(arr, left, j);
            if (i < right) DoQuickSortDescending(arr, i, right);
            Console.WriteLine("\nThe amount of steps that have occured is {0}\n", count);
            return arr;

        }
    }
    public class MergesortAscending 
    {
        public static int count = 0; //Universal count

        public static void MergeSort(double[] input, int low, int high)
        {
            if (low < high) 
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(input, low, middle);
                MergeSort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }
        public static double[] DoMergeSortAscending(double[] input)
        {
            MergeSort(input, 0, input.Length - 1);
            return input;
        }
        private static void Merge(double[] input, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            double[] tmp = new double[(high - low) + 1];
            int tmpIndex = 0;
            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }
            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }
            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }
            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
                count++;
            }

        }
    }
    public static class MergesortDescending
    {
        public static int count = 0;

        public static void MergeSort(double[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(input, low, middle);
                MergeSort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }
        public static double[] DoMergeSortDescending(double[] input)
        {
            MergeSort(input, 0, input.Length - 1);
            return input;
        }
        private static void Merge(double[] input, int low, int middle, int high)
        {
            int milliseconds = 550;
            int left = low;
            int right = middle + 1;
            double[] tmp = new double[(high - low) + 1];
            int tmpIndex = 0;
            while ((left <= middle) && (right <= high))
            {
                if (input[left] > input[right]) //switched to > to try and make the algorithm descending 
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }
            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }
            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }
            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
                count++;
            }
            Console.WriteLine("The number of steps that occured was {0}", count);
        }
    }
    public static class BinarySearchAscending
    {
        public static double[] DoBinarySearchAscending(double[] numbers, int left, int right, double key)
        {
            double[] container = new double[20]; //Container that is used in a few of my algorithms
            int Temp;
            int counter = 1;


            int mid = (left + right) / 2;


            if (key < numbers[0])
            {
                Console.WriteLine("The key is too low and does not belong in the range"); //Allows the user to know that the value they entered is too low for the range and that they need to input another value
                return container;
            }
            if (key > numbers[numbers.Length - 1])
            {
                Console.WriteLine("The key is too high and does not belong in the range"); //Allows the user to know that the value they entered is too high for the range and that they need to input another value
                return container;
            }

            if (numbers[mid] == key)
            {
                container[0] = mid;
                Temp = mid + 1;

                while (key == numbers[Temp])
                {
                    container[counter] = Temp;
                    Temp++;
                    counter++;
                }
                Temp = mid - 1;
                while (numbers[Temp] == key)
                {
                    container[counter] = Temp;
                    Temp--;
                    counter++;
                }

                return container;
            }

            if (numbers[mid] > key)
            {
                return DoBinarySearchAscending(numbers, left, mid - 1, key);
            }

            return DoBinarySearchAscending(numbers, mid + 1, right, key);
        }

    }
    public static class BinarySearchDescending
    {
        public static double[] DoBinarySearchDescending(double[] numbers, int left, int right, double key)
        {

            double[] container = new double[20];
            int Temp;
            int counter = 1;

            int mid = (left + right) / 2;

            if (key > numbers[0])
            {
                Console.WriteLine("The key is too high and does not belong in the range");
                return container;
            }
            if (key < numbers[numbers.Length - 1])
            {
                Console.WriteLine("The key is too low and does not belong in the range");
                return container;
            }

            if (key == numbers[mid])
            {
                container[0] = mid;
                Temp = mid + 1;

                while (numbers[Temp] == key)
                {
                    container[counter] = Temp;
                    Temp++;
                    counter++;
                }
                Temp = mid - 1;
                while (key == numbers[Temp])
                {
                    container[counter] = Temp;
                    Temp--;
                    counter++;
                }

                return container;
            }

            if (numbers[mid] < key)
            {
                return DoBinarySearchDescending(numbers, mid + 1, right, key);
            }

            return DoBinarySearchDescending(numbers, mid + 1, right, key);
        }
    }
    public static class BubbleSortAscending
    {
        public static int count = 0;
        public static double[] DoBubbleSortAscending(double[] arr, double num)
        {
            for (int i = 0; i < num - 1; i++)
            {
                for (int j = 0; j < num - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        double temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        count++;
                    }
                }
            }
            return arr;
        }
    }
    public static class BubbleSortDescending
    {
        public static int count = 0;
        public static double[] DoBubbleSortDescending(double[] arr, double num)
        {
            for (int i = 0; i < num - 1; i++) //changed arrow to > to see if this changes code to descending order
            {
                for (int j = 0; j < num - 1; j++)
                {
                    if (arr[j + 1] > arr[j])
                    {
                        double temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        count++;

                    }
                }
            }
            return arr;
        }
    }
    public static class InterpolationSearchAscending
    {
        public static double[] DoIntSearch(double[] list, double data)
        {
            double[] container = new double[20];

            int lo = 0;
            int mid = -1;
            int hi = list.Length - 1;
            int index = -1;
            int counter = 1;
            int temp;
            int midtemp = -1;

            while (lo <= hi)
            {
                mid = Convert.ToInt32(((hi - lo) / (list[hi] - list[lo]) * (data - list[lo]) + lo));
                if (data < list[0])
                {
                    Console.WriteLine("The key is too low and does not belong in the range");
                    return container;
                }
                if (data > list[list.Length - 1])
                {
                    Console.WriteLine("The key is too high and does not belong in the range");
                    return container;
                }
                if (list[mid] == data)
                {
                    index = mid;
                    container[0] = index;
                    temp = index + 1;
                    while (data == list[temp])
                    {
                        container[counter] = temp;
                        temp++;
                        counter++;
                    }
                    temp = index - 1;
                    while (data == list[temp])
                    {
                        container[counter] = temp;
                        temp--;
                        counter++;
                    }

                    break;
                }
                else
                {
                    if (list[mid] < data)
                        lo = mid - 1;
                    else if (list[mid] > data)
                        hi = mid + 1;
                }

                if (midtemp == mid)
                {
                    Console.WriteLine("The key was not found. The closest value was: {0} at position {1}", list[mid], mid + 1); //If the key was not found this message will appear on the screen
                    break;
                }

                midtemp = mid;
            }

            return container;
        }
    }
    public static class InterpolationSearchDescending
    {

        public static double[] DoIntSearchDec(double[] list, double data)
        {
            double[] container = new double[20];

            int lo = 0;
            int mid = -1;
            int hi = list.Length - 1;
            int index = -1;
            int counter = 1;
            int temp;
            int midtemp = -1;

            while (lo <= hi)
            {
                mid = Convert.ToInt32(((hi - lo) / (list[hi] - list[lo]) * (data - list[lo]) + lo));

                if (data < list[0])
                {
                    Console.WriteLine("The key is too low and does not belong in the range");
                    return container;
                }
                if (data > list[list.Length - 1])
                {
                    Console.WriteLine("The key is too high and does not belong in the range");
                    return container;
                }
                if (list[mid] == data)
                {
                    index = mid;
                    container[0] = index;
                    temp = index + 1;
                    while (data == list[temp])
                    {
                        container[counter] = temp;
                        temp++;
                        counter++;
                    }
                    temp = index - 1;
                    while (data == list[temp])
                    {
                        container[counter] = temp;
                        temp--;
                        counter++;
                    }

                    break;
                }
                else
                {
                    if (list[mid] > data) //Switched arrows around so that I could run in decending order
                        lo = mid - 1;
                    else if (list[mid] < data)
                        hi = mid + 1;
                }

                if (midtemp == mid)
                {
                    Console.WriteLine("The key was not found. The closest value was: {0} at position {1}", list[mid], mid + 1);
                    break;
                }

                midtemp = mid;
            }

            return container;
        }
    }
}




