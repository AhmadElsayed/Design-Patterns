using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MuMTest
    {

        // In case that System,Linq is not included or not permited in the exam this function can be used instead on deleted.Contains
        private bool ArrayContains(int[] Arr, int val)
        {
            bool found = false;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == val)
                {
                    found = true;
                    break; ;
                }
            }
            return found;
        }

        private int choose(int[] a, int n)
        {
            // deleted array to add all the deleted Indexes into it.
            // The last element will always equal -1
            int[] deleted = new int[a.Length];

            // initialize the deleted array with -1 to prevent the conflict when checking on the 0s later 
            for (int i = 0; i < deleted.Length; i++)
                deleted[i] = -1;

            int nextElement = (n - 1) % a.Length;

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (i != 0)
                {
                    // Calculate the next index to be deleted
                    int indx = 0, lastVisited = deleted[i - 1];
                    do
                    {
                        int newLastVisitedVal = (lastVisited + 1) % deleted.Length;
                        if (ArrayContains(deleted, newLastVisitedVal))
                        {
                            lastVisited = newLastVisitedVal;
                            continue;
                        }
                        else
                        {
                            lastVisited = newLastVisitedVal;
                            indx++;
                        }
                    } while (indx < n);
                    nextElement = lastVisited;

                }
                deleted[i] = nextElement;
            }

            // Get the only index that didn't deleted yet.
            int theChosenIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (!ArrayContains(deleted, i))
                {
                    theChosenIndex = i;
                    break;
                }
            }

            return a[theChosenIndex];
        }

        private double eval(double x, int[] a)
        {
            double result = 0;
            // anxn + an-1xn-1 + ... + a1x1 + a0
            for (int i = a.Length - 1; i >= 0; i--)
            {
                result += a[i] * Math.Pow(x, i);
            }
            return result;
        }

        private int isBalanced(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (a[i] % 2 == 0)
                        continue;
                    else
                        return 0;
                }
                else
                {
                    if (a[i] % 2 != 0)
                        continue;
                    else
                        return 0;
                }
            }
            return 1;
        }

    }
}
