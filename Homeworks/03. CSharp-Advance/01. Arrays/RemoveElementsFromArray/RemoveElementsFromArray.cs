/*Problem 18.* Remove elements from array
Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array 
is sorted in increasing order. Print the minimal number of elements that need to be removed in order for the array to become sorted.
On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Print the minimal number of elements that need to be removed

Example:
input             result    
8                   3
1
4
3
3
6
3
2
3
*/


using System;

class RemoveElements
{
    static void Main()
    {
        //http://www.algorithmist.com/index.php/Longest_Increasing_Subsequence

        int arraySize = int.Parse(Console.ReadLine());
        var toSearch = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            toSearch[i] = (int.Parse(Console.ReadLine()));
        }

        var helperArray = new int[arraySize];
        int MaxSeqLength = 0;

        for (int EndPoint = 0; EndPoint < toSearch.Length; EndPoint++)              
        {                                                                        
            MaxSeqLength = 0;
            
            // If current Start Point element is smaller than the at End Point there are members of the same sequence
            for (int StartPoint = 0; StartPoint < EndPoint; StartPoint++)
            {                                                    
                if (toSearch[EndPoint] >= toSearch[StartPoint])                       
                {
                    if (helperArray[StartPoint] > MaxSeqLength)  
                    {                                            
                        MaxSeqLength = helperArray[StartPoint];  
                    }                                           
                }                                              
            }                                                    

            // Longest existing sequence
            // the current EndPoint element belogs to
            // plus the current element
            // sequence of at least 1 elements
            helperArray[EndPoint] = MaxSeqLength + 1;
        }

        MaxSeqLength = 0;

        // Find the Max
        for (int i = 0; i < arraySize; i++) 
        {                                        
            if (helperArray[i] > MaxSeqLength)
            {                                   
                MaxSeqLength = helperArray[i]; 
            }                                   
        }                                       

        Console.WriteLine(arraySize - MaxSeqLength);
    }
}
