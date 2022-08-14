// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
double Distance(double[] A, double[] B)
{
    double distance = Math.Sqrt(Math.Pow(A[0] - B[0], 2) + Math.Pow(A[1] - B[1], 2) + Math.Pow(A[2] - B[2], 2));
    Console.WriteLine(Math.Round(distance, 2));
    return distance;
}

Distance(new double[] {3, 6, 8}, new double[] {2, 1, -7});
Distance(new double[] {7, -5, 0}, new double[] {1, -1, 9});