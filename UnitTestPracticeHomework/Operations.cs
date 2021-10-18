using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestPracticeHomework
{
    public class Operations
    {
        public double DoOperation(double[] arrNumbers, string[] operators)
        {
            int countCases = 0;
            double resultOperation = 0;
            int operatorCount = 1;

            if ((arrNumbers.Length - operators.Length) == 1)
            {
                foreach (string key in operators)
                {

                    if (key == "+") {
                        if (countCases == 0)
                        {
                            resultOperation = arrNumbers[countCases] + arrNumbers[(countCases + 1)];
                            countCases += 2;
                            if (operatorCount == operators.Length)
                            {
                                return resultOperation;
                            }
                            operatorCount++;
                        }
                        else if (countCases > 0)
                        {
                            resultOperation = resultOperation + arrNumbers[countCases];
                            countCases++;
                            if (operatorCount == operators.Length)
                            {
                                return resultOperation;
                            }
                            operatorCount++;
                        }
                    } 
                    else if (key == "-")
                    {
                        if (countCases == 0)
                        {
                            resultOperation = arrNumbers[countCases] - arrNumbers[(countCases + 1)];
                            countCases += 2;
                            if (operatorCount == operators.Length)
                            {
                                return resultOperation;
                            }
                            operatorCount++;
                        }
                        else if (countCases > 0)
                        {
                            resultOperation = resultOperation - arrNumbers[countCases];
                            countCases++;
                            if (operatorCount == operators.Length)
                            {
                                return resultOperation;
                            }
                            operatorCount++;
                        }
                    } 
                    else if (key == "*") 
                    {
                        if (countCases == 0)
                        {
                            resultOperation = arrNumbers[countCases] * arrNumbers[(countCases + 1)];
                            countCases += 2;
                            if (operatorCount == operators.Length)
                            {
                                return resultOperation;
                            }
                            operatorCount++;
                        }
                        else if (countCases > 0)
                        {
                            resultOperation = resultOperation * arrNumbers[countCases];
                            countCases++;
                            if (operatorCount == operators.Length)
                            {
                                return resultOperation;
                            }
                            operatorCount++;
                        }
                    } 
                    else if (key == "/")
                    {
                        if (countCases == 0)
                        {
                            resultOperation = arrNumbers[countCases] / arrNumbers[(countCases + 1)];
                            countCases += 2;
                            if (operatorCount == operators.Length)
                            {
                                return resultOperation;
                            }
                            operatorCount++;
                        }
                        else if (countCases > 0)
                        {
                            resultOperation = resultOperation / arrNumbers[countCases];
                            countCases++;
                            if (operatorCount == operators.Length)
                            {
                                return resultOperation;
                            }
                            operatorCount++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad operation, there is a wrong character.");
                        return 0;
                    }
                }
            }
            else
            {
                Console.WriteLine("Error in the structure of the operators and numbers, verify that your operators are one less that your numbers.");
                return 0;
            }
            return resultOperation;
        }
    }
}
