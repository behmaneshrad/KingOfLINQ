namespace KingOfLINQ
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFrm000_Click(object sender, EventArgs e)
        {

        }

        private static bool IsAny(int[] numbers,Func<int , bool> predicate)
        {
            foreach (var number in numbers)
            {
                if (predicate(number))
                    return true;
            }

            return false;
        }

        public static bool IsAnyLargerThan20(int number)
        {
            return number > 20;
        }

        public static bool IsAnyEven(int number)
        {
            return number % 2 == 0;
        }

        private void btnIntroduction_Click(object sender, EventArgs e)
        {

            /*
             Important Points: 
             1.Lambda expressions allow us to create anonymous functions.
             2.In C# we can use functions like any other types - store them in variables or pass as parameters.
             */



            string msg = "";
            var numbers = new[] { 3, 21, 13, 49, 7, 35, 1 };

            bool isAnyLargerThan20 = true;

            msg = $"Is any Larger than 20 By Func : { IsAny(numbers, IsAnyLargerThan20) } \n";

            msg += $"Is any Larger than 20 By Linq From1: { IsAny(numbers, number => number > 20) } \n";


            bool isAny = IsAny(numbers, number =>
            {
                const int max = 20;
                return number > max;
            });

            msg += $"Is any Larger than 20 By Linq Form2: { isAny } \n";

            Func<int, bool> IsAnyLargerThan20Fn = number => number > 20;
            msg += $"Is any Larger than 20 By Linq From3: { IsAny(numbers, IsAnyLargerThan20Fn) } \n";

            bool isAnyEven = false;
            msg += $"Is any Even : { IsAny(numbers, IsAnyEven) } \n";

            msg += $"Is any Even By Linq: { IsAny(numbers, number => number % 2 == 0) } \n";

            MessageBox.Show(msg);
        }
    }
}