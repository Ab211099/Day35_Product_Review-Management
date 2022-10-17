namespace Day35_ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            List<Product_Review> products = new List<Product_Review>();
            try
            {
                Console.WriteLine("1: Add Product Review To List \n2.To display the list \n3: Exit");
                Console.Write("Choose the option from above : ");
                int option = Convert.ToInt32(Console.ReadLine());
                bool flag = true;
                switch (option)
                {
                    case 1:
                        products = AddValues.AddProductReviewToList();
                        break;
                    case 2:
                        products = AddValues.AddProductReviewToList();
                        AddValues.IterateOverList(products);
                        break;

                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Wrong choice choose again");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}