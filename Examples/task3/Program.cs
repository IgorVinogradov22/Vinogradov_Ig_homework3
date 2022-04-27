
void Dist3D (int [] arr)

{
      int x1 = 1;
      int y1 = 9;
      int z1 = 11;
      int x2 = 5;
      int y2 = 27;
      int z2 = 14;

      int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
      if (i == 0)
      {
        arr [0] = x1;
      }
      if (i == 1)
      {
        arr [1] = y1;
      }
      if (i == 2)
      {
        arr [2] = z1;
      }
      if (i == 3)
      {
        arr [3] = x2;
      }
      if (i == 4)
      {
        arr [4] = y2;
      }
      if (i == 5)
      {
        arr [5] = z2;
      }
          
      double rasst = Math.Sqrt (Math.Pow (x2 - x1,2) + Math.Pow (y2 - y1,2) + Math.Pow (z2 - z1,2));
      Console.WriteLine (rasst);
      
    }  
}   
   
 int [] arr = new int [1];

 Dist3D (arr);
    












