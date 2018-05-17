using System;

namespace ClassExample
{
	class Test
    {
		public string Name { get; set; }
		public string Department { get; set; }
		bool DFlag = false;
        
		public Test()
        {
			Console.WriteLine("Работает конструктор");
        }
        
		~Test()
        {
			Console.WriteLine("Работает деструктор");
			Dispose();

        
		}

		public void Show(){
			Console.WriteLine("Name: " + Name + "\nDepartment: " + Department+"\n------------");
		}
        
		public void Dispose() 
        {
            Console.WriteLine("Работает Dispose public");
            Dispose(true);
            //GC.SuppressFinalize(this);
        }

		private void Dispose(bool flag)
        {
			if (DFlag == false)
				if (flag)
			        {
				        Console.WriteLine("Работает Dispose private");
					    flag = true;
                        GC.SuppressFinalize(this);
			        }
         
        }
    

    }

    class Program
    {
        static void Main(string[] args)
        {
			Test test1_obj = new Test { Name = "Кирилл Ерошкин"};
			test1_obj.Show();
			test1_obj.Dispose();
			Test test2_obj = new Test { Department = "Кембридж" };
			test2_obj.Show();
			test2_obj.Dispose();
			Test test3_obj = new Test { Name = "Геннадий", Department = "Оксворд" };
			test3_obj.Show();
            test3_obj.Dispose();
			//delete test3_obj;


        }
    }
}
