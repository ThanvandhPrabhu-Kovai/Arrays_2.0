using System;

namespace Arrays_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // get3x3Matrix();
            // getSumOf2SquareMatrices();
            // getDifferenceOf2SquareMatrices();
            //getProductOf2Matrices();
            getTransposeOf2matrices();
            Console.ReadLine();
        }

        static int getUserInput() => Convert.ToInt32(Console.ReadLine());

        static int[,] generateSquareMatrixFromUserInput(int sizeOfMatrix) {
            int[,] result = new int[sizeOfMatrix, sizeOfMatrix];
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    result[i, j] = getUserInput();
                }
            }
            return result;
        }

        static int[,] generateMatrixFromUserInput(int rows, int columns) {
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    result[i, j] = getUserInput();
                }
            }
            return result;
        }

        static void printMatrix(int rows, int columns, int[,] matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < columns; j++)
                    Console.Write("{0}\t", matrix[i, j]);
            }
        }

        static void printSquareMatrix(int sizeOfMatrix, int[,] matrix)
        {
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    int element = matrix[i, j];
                    Console.Write("{0}\t", element);
                }
                Console.Write("\n");
            }
        }

        //program to get 3 X 3 matrix
        static void get3x3Matrix()
        {
            Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix : ");
            Console.Write("\n\n---------------------------------------------------");
            Console.Write("\n\nInput elements in the matrix : ");

            int[,] matrix = new int[3, 3];

            Console.Write("Input elements in the matrix :\n");

            matrix = generateSquareMatrixFromUserInput(3);

            Console.Write("\n\nThe matrix is : \n\n");

            printSquareMatrix(3, matrix);
        }

        //program for addition of two Matrices of same size.
        static void getSumOf2SquareMatrices()
        {
           

            Console.Write("\n\nAddition of two Matrices : ");
            Console.Write("\n\n-----------------------------------------");

            Console.Write("\n\nInput the size of the square matrix (less than 5) : ");
            int sizeOfMatrix = getUserInput();
            
            if (sizeOfMatrix<5) {
                int[,] matrix1 = new int[sizeOfMatrix, sizeOfMatrix];
                int[,] matrix2 = new int[sizeOfMatrix, sizeOfMatrix];

                int[,] sum = new int[sizeOfMatrix, sizeOfMatrix];
                Console.Write("\n\nInput elements in the first matrix : \n\n");
                matrix1 = generateSquareMatrixFromUserInput(sizeOfMatrix);

                Console.Write("\n\nInput elements in the second matrix : \n\n");
                matrix2 = generateSquareMatrixFromUserInput(sizeOfMatrix);

                for (int i = 0; i < sizeOfMatrix; i++)
                {
                    for (int j = 0; j < sizeOfMatrix; j++)
                    {
                        int elementFromMatrix1 = matrix1[i, j];
                        int elementForMatrix2 = matrix2[i, j];
                        int sumOf2Elements = elementFromMatrix1 + elementForMatrix2;
                        sum[i, j] = sumOf2Elements;
                    }
                }

                for (int k = 0; k < 3; k++)
                {
                    if (k == 0)
                    {
                        Console.Write("\n\nThe First matrix is : \n\n");
                        printSquareMatrix(sizeOfMatrix, matrix1);
                    }
                    else if (k == 1)
                    {
                        Console.Write("\n\nThe Second matrix is : \n\n");
                        printSquareMatrix(sizeOfMatrix, matrix2);
                    }
                    else
                    {
                        Console.Write("\n\nThe Addition of two matrices is : \n\n");
                        printSquareMatrix(sizeOfMatrix, sum);
                    }
                }
            }else {
                Console.Write("\n\nInvalid input detected!");
            }
        }

        //program for subtraction of two Matrices.
        static void getDifferenceOf2SquareMatrices()
        {

            Console.Write("\n\nSubtraction of two Matrices : ");
            Console.Write("\n\n-----------------------------------------");

            Console.Write("\n\nInput the size of the square matrix (less than 5) : ");
            int sizeOfMatrix = getUserInput();

            if (sizeOfMatrix < 5)
            {
                int[,] matrix1 = new int[sizeOfMatrix, sizeOfMatrix];
                int[,] matrix2 = new int[sizeOfMatrix, sizeOfMatrix];

                int[,] difference = new int[sizeOfMatrix, sizeOfMatrix];

                Console.Write("\n\nInput elements in the first matrix : \n\n");
                matrix1 = generateSquareMatrixFromUserInput(sizeOfMatrix);

                Console.Write("\n\nInput elements in the second matrix : \n\n");
                matrix2 = generateSquareMatrixFromUserInput(sizeOfMatrix);

                for (int i = 0; i < sizeOfMatrix; i++)
                {
                    for (int j = 0; j < sizeOfMatrix; j++)
                    {
                        int elementFromMatrix1 = matrix1[i, j];
                        int elementForMatrix2 = matrix2[i, j];
                        int differenceOf2Matrices = elementFromMatrix1 - elementForMatrix2;
                        difference[i, j] = differenceOf2Matrices;
                    }
                }

                for (int k = 0; k < 3; k++)
                {
                    if (k == 0)
                    {
                        Console.Write("\n\nThe First matrix is : \n\n");
                        printSquareMatrix(sizeOfMatrix, matrix1);
                    }
                    else if (k == 1)
                    {
                        Console.Write("\n\nThe Second matrix is : \n\n");
                        printSquareMatrix(sizeOfMatrix, matrix2);
                    }
                    else
                    {
                        Console.Write("\n\nThe Subtraction of two matrices is : \n\n");
                        printSquareMatrix(sizeOfMatrix, difference);
                    }
                }
            }
            else
            {
                Console.Write("\n\nInvalid input detected!");
            }
        }

        //program for multiplying two matrices
        static void getProductOf2Matrices()
        {

            int  r1, c1, r2, c2;

            int[,] arr1 = new int[50, 50];
            int[,] brr1 = new int[50, 50];
            int[,] crr1 = new int[50, 50];

            Console.Write("\n\nMultiplication of two Matrices");
            Console.Write("\n\n----------------------------------");

            Console.Write("\n\nInput the number of rows and columns of the first matrix : ");
            Console.Write("\n\nRows : ");
            r1 = getUserInput();
            Console.Write("\n\nColumns : ");
            c1 = getUserInput();

            Console.Write("\n\nInput the number of rows of the second matrix : ");
            Console.Write("\n\nRows : ");
            r2 = getUserInput();
            Console.Write("\n\nColumns : ");
            c2 = getUserInput();

            if (c1 != r2)
            {
                Console.Write("Mutiplication of Matrix is not possible.");
                Console.Write("\nColumn of first matrix and row of second matrix must be same.");
            }
            else
            {

                //Get elements for matrix 1
                Console.Write("\n\nInput elements in the first matrix :\n\n");
                arr1 = generateMatrixFromUserInput(r1, c1);

                //Get elements for matrix 2
                Console.Write("\n\nInput elements in the second matrix :\n\n");
                brr1 = generateMatrixFromUserInput(r2, c2);

                //Print first matrix
                Console.Write("\n\nThe First matrix is : ");
                printMatrix(r1, c1, arr1);

                //Print second matrix
                Console.Write("\n\nThe Second matrix is : ");
                printMatrix(r2, c2, brr1);

                //Get the product of matrices
                //Inititate result matrix
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        crr1[i, j] = 0;
                    }
                }

                for (int i = 0; i < r1; i++)    //row of first matrix
                {
                    for (int j = 0; j < c2; j++)    //column of second matrix
                    {
                        int sum = 0;
                        for (int k = 0; k < c1; k++)
                        {
                            sum += arr1[i, k] * brr1[k, j];
                        }
                        crr1[i, j] = sum;
                    }
                }
                
                Console.Write("\n\nThe multiplication of two matrix is : ");
                printMatrix(r1, c2, crr1);
            }
            Console.Write("\n\n");
        }

        static void getTransposeOf2matrices() {
            int i, j, r, c;
            int[,] arr1 = new int[50, 50];
            int[,] brr1 = new int[50, 50];


            Console.Write("\n\nTranspose of a Matrix : ");
            Console.Write("\n\n---------------------------");

            Console.Write("\n\nInput the number of rows and columns of the first matrix : ");
            Console.Write("\n\nRows : ");
            r = getUserInput();
            Console.Write("\n\nColumns : ");
            c = getUserInput();


            Console.Write("\n\nInput elements in the matrix : \n\n");
            arr1 = generateMatrixFromUserInput(r, c);

            Console.Write("\n\nThe First matrix is : ");
            printMatrix(r, c, arr1);

            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    brr1[j, i] = arr1[i, j];
                }
            }

            Console.Write("\n\nThe Transpose of a matrix is : ");
            printMatrix(c, r, brr1);
            Console.Write("\n\n");
        }

    }
}
