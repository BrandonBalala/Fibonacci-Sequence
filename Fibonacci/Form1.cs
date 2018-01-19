using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

        
            /**
             * 
             * This method is used to calculate the fibonacci number given any
             * positif number by using a recursive method and returns the result
             * 
             */
            private static int calculateFibRecursive(int n)
            {
                if (n <= 2)
                    return 1;

                int x = calculateFibRecursive(n - 1) ;
                int y = calculateFibRecursive(n - 2) ;

                int z = x + y;

                return z;
            }

            /**
             * 
             * This method is used to calculate the fibonacci number given any
             * positif number by using a loop and returns a loop
             * 
             */
            public static int calculateFibLoop(int n)
            {
                int x = 0;
                int y = 1;
                int temp;

                for (int i = 0; i < n; i++)
                {
                    temp = x;
                    x = y;
                    y = temp + y;
                }

                return x;
            }

            /**
             * 
             * This method is invoked when the calculate button is clicked.
             * This takes care of the data validation and invokes a call 
             * to respective method wether loop and/or recursive method is 
             * checked. 
             * 
             */
            private void calculateButton_Click(object sender, EventArgs e)
            {
                string number = fibonacciTextBox.Text.Trim();
                int value = -1;

                int.TryParse(number, out value);
            
                if(value != -1 && value > 0)
                {
                    loopResultTextBox.Text = null;
                    loopTimeTextBox.Text = null;
                    recursiveResultTextBox.Text = null;
                    recursiveTimeTextBox.Text = null;

                    if(loopCheckBox.Checked && recursiveCheckBox.Checked)
                    {
                        recursiveOption(value);
                        loopOption(value);
                    }
                    else if(loopCheckBox.Checked)
                        loopOption(value);
                    else if(recursiveCheckBox.Checked)
                        recursiveOption(value);
                }
            }

            //48 MAX WITH RECURSIVE BEFORE INTEGER OVERFLOW

            /**
             * 
             * This method invokes the loop fibonacci calculations method.
             * It also makes use of a stopwatch to calculate the elapsed time
             * for it to finish the calculation and get the fibonacci number.
             * Finally it displays the results in the respective text boxes.
             * 
             */
            private void loopOption(int value)
            {
                int result;
                string fibString;
                Stopwatch sw;
                TimeSpan elapsedTime;

                //Start stopwatch
                sw = Stopwatch.StartNew();
                result = calculateFibLoop(value);
                //Stop stopwatch
                sw.Stop();
                //Calculate elapsed time
                elapsedTime = sw.Elapsed;

                //Display in text boxes
                fibString = "Fib(" + value + ") = " + result.ToString() ;
                loopResultTextBox.Text = fibString;
                loopTimeTextBox.Text = elapsedTime.ToString();
                fibonacciTextBox.Text = null;
            }


            /**
             * 
             * This method invokes the recursive fibonacci calculation method.
             * It also makes use of a stopwatch to calculate the elapsed time
             * for it to finish the calculation and get the fibonacci number.
             * Finally it displays the results in the respective text boxes.
             * 
             */
            private void recursiveOption(int value)
            {
                int result;
                string fibString;
                Stopwatch sw;
                TimeSpan elapsedTime;

                //Start stopwatch
                sw = Stopwatch.StartNew();
                result = calculateFibRecursive(value);
                //Stop stopwatch
                sw.Stop();
                //Calculate elapsed time
                elapsedTime = sw.Elapsed;

                //Display in text boxes
                fibString = "Fib(" + value + ") = " + result.ToString();
                recursiveResultTextBox.Text = fibString;
                recursiveTimeTextBox.Text = elapsedTime.ToString();
                fibonacciTextBox.Text = null;
            }
        
    }
}
