using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_factory
{
    abstract class Product
    {
        public abstract void Display();
    }

   
    class Button : Product
    {
        public override void Display()
        {
            Console.WriteLine("Button");
        }
    }

   
    class RadioButton : Product
    {
        public override void Display()
        {
            Console.WriteLine("RadioButton");
        }
    }


    class CheckButton : Product
    {
        public override void Display()
        {
            Console.WriteLine("CheckButton");
        }
    }

  
    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

  
    class ButtonCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new Button();
        }
    }


    class RadioButtonCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new RadioButton();
        }
    }

    class CheckButtonCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new CheckButton();
        }
    }

    
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Create a Button");
            Creator buttonCreator = new ButtonCreator();
            Product button = buttonCreator.FactoryMethod();
            button.Display();

            Console.WriteLine("Create a RadioButton");
            Creator radioButtonCreator = new RadioButtonCreator();
            Product radioButton = radioButtonCreator.FactoryMethod();
            radioButton.Display();

            Console.WriteLine("Create a CheckButton");
            Creator checkButtonCreator = new CheckButtonCreator();
            Product checkButton = checkButtonCreator.FactoryMethod();
            checkButton.Display();
        }
    }



}
