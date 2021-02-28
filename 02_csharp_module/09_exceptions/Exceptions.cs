using System;

namespace Exceptions
{
    //TODO: Create custom exception "MatrixException"
    
    public class MatrixException : Exception
    {
        public MatrixException()
        {
        }

        public MatrixException(string message)
            : base(message)
        {
        }

        public MatrixException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    
    public class Matrix
    {

        /// <summary>
        /// Number of rows.
        /// </summary>
        public int Rows
        {

            get; //=> throw new NotImplementedException();
    
        }


        /// <summary>
        /// Number of columns.
        /// </summary>
        public int Columns
        {
            get; // => throw new NotImplementedException();
        }


        /// <summary>
        /// An array of floating-point values that represents the elements of this Matrix.
        /// </summary>
        public double[,] Array
        {
            get; //=> throw new NotImplementedException();
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when row or column is zero or negative.</exception>
        public Matrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
                throw new ArgumentOutOfRangeException();
            else
            {
              Matrix[,] myMatrix = new Matrix[rows, columns];
            }
            
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class with the specified elements.
        /// </summary>
        /// <param name="array">An array of floating-point values that represents the elements of this Matrix.</param>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        public Matrix(double[,] array)
        {

            if (array == null)
                throw new ArgumentNullException();
            
            else
            {
               // Matrix[,] myMatrix2 = new Matrix[array.GetLength(0), array.GetLength(1)];
            }
            
        }
    
        

        /// <summary>
        /// Allows instances of a <see cref="Matrix"/> to be indexed just like arrays.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <exception cref="ArgumentException">Thrown when index is out of range.</exception>
        public double this[int row, int column]
        {
            get  => throw new ArgumentException();
            set => throw new ArgumentException();
        }


        /// <summary>
        /// Adds <see cref="Matrix"/> to the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for adding.</param>
        /// <exception cref="ArgumentNullException">Thrown when parameter is null.</exception>
        /// <exception cref="MatrixException">Thrown when the matrix has the wrong dimensions for the operation.</exception>
        /// <returns><see cref="Matrix"/></returns>
        public Matrix Add(Matrix matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException();
            else
                return matrix; // MAKE ADDITION
        }


        /// <summary>
        /// Subtracts <see cref="Matrix"/> from the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for subtracting.</param>
        /// <exception cref="ArgumentNullException">Thrown when parameter is null.</exception>
        /// <exception cref="MatrixException">Thrown when the matrix has the wrong dimensions for the operation.</exception>
        /// <returns><see cref="Matrix"/></returns>
        public Matrix Subtract(Matrix matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException();
            else
                return matrix; // MAKE SUBSTRACTION
        }


        /// <summary>
        /// Multiplies <see cref="Matrix"/> on the current matrix.
        /// </summary>
        /// <param name="matrix"><see cref="Matrix"/> for multiplying.</param>
        /// <exception cref="ArgumentNullException">Thrown when parameter is null.</exception>
        /// <exception cref="MatrixException">Thrown when the matrix has the wrong dimensions for the operation.</exception>
        /// <returns><see cref="Matrix"/></returns>
        public Matrix Multiply(Matrix matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException();
            else
                return matrix; // MAKE MULT
        }
    }
}