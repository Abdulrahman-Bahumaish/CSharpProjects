using ExercisesOOPMatrix;

Console.WriteLine("Enter The Two Numbers :");
int C = Convert.ToInt32(Console.ReadLine());
int R = Convert.ToInt32(Console.ReadLine());
Matrix MatrixTowDimn = new Matrix(C, R);
MatrixTowDimn.ReadMatrix();
MatrixTowDimn.TransposeMatrix();