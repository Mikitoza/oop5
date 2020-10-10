using System;

namespace laba5_oop
{
    public class Figure 
    {
        public int heigth;
        public int Heigth
        {
            get
            {
                return heigth;
            }
            set
            {
                if (value < 0)
                    heigth = value;
            }
        }
        public int weigth;
        public int Weigth
        {
            get
            {
                return weigth;
            }
            set
            {
                if (value < 0)
                    Weigth = value;
            }
        }
        public string color_name;
        public string Color
        {
            get
            {
                return color_name;
            }
            set
            {
                color_name = value;
            }
        }
        public string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
        public override string ToString()
        {
            return $"{heigth}.{weigth}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
    abstract class Rectangle : Figure
    {
       public abstract void DoClone();
       public void Rectangle_info()
        {
            Console.WriteLine("Прямоугольник");
        }
    }
    class Window : Rectangle , Registration
    {
        public override void DoClone()
        {
            Console.WriteLine("Можно клонировать");
        }
        public override void Display()
        {
            base.Display();
        }
        public void color()
        { 
            Console.WriteLine($"Цвет окна - {color_name}");
        }
        public void heigth_size()
        {
            Console.WriteLine($"Высота окна - {heigth}");
        }
        public void weigth_size()
        {
            Console.WriteLine($"Ширина окна - {weigth}");
        }
        public override string ToString()
        {
            return $"{heigth}.{weigth}.{color_name}.{name}";
        }
    }
    class Menu : Rectangle , Registration
    { 
        public override void DoClone()
        {
            Console.WriteLine("Можно клонировать");
        }
        public override void Display()
        {
            base.Display();
        }
        public void color()
        {
            Console.WriteLine($"Цвет Меню - {color_name}");
        }
        public void heigth_size()
        {
            Console.WriteLine($"Высота меню - {heigth}");
        }
        public void weigth_size()
        {
            Console.WriteLine($"Ширина меню - {weigth}");
        }
        public override string ToString()
        {
            return $"{heigth}.{weigth}.{color_name}.{name}";
        }
    }
    class Button : Rectangle , Registration
    {
        public override void DoClone()
        {
            Console.WriteLine("Можно клонировать");
        }
        public override void Display()
        {
            base.Display();
        }
        public void color()
        {
            Console.WriteLine($"Цвет кнопки - {color_name}");
        }
        public void heigth_size()
        {
            Console.WriteLine($"Высота кнопки - {heigth}");
        }
        public void weigth_size()
        {
            Console.WriteLine($"Ширина кнопки - {weigth}");
        }
        public override string ToString()
        {
            return $"{heigth}.{weigth}.{color_name}.{name}";
        }
    }
    interface Registration
    {
        void DoClone();
        void color();
        void heigth_size();
        void weigth_size();
    }
    class Printer : some
    {
        public string whatimprinting;
    }
    abstract class some
    {
        public void IamPrinting(Rectangle someobj)
        {
            Console.WriteLine($"type of obj is: " + someobj.GetType() + " ");
            Console.WriteLine(someobj.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window { Heigth = 200, Weigth = 200, Color = "red" ,Name="окно"};
            window.color();
            window.Display();
            window.DoClone();
            window.heigth_size();
            window.Rectangle_info();
            window.ToString();
            window.weigth_size();
            Menu menu = new Menu { Heigth = 200, Weigth = 200, Color = "green", Name = "menu" };
            menu.color();
            menu.Display();
            menu.DoClone();
            menu.heigth_size();
            menu.Rectangle_info();
            menu.ToString();
            menu.weigth_size();
            Button button = new Button { Heigth = 200, Weigth = 200, Color = "black", Name = "button" };
            button.color();
            button.Display();
            button.DoClone();
            button.heigth_size();
            button.Rectangle_info();
            button.ToString();
            button.weigth_size();
            Printer print = new Printer();
            print.IamPrinting(window);
            print.IamPrinting(menu);
            print.IamPrinting(button);
        }
    }
}
