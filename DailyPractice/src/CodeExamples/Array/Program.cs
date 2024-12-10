//Single Dimensional Array
string[] names = new string[5];
names[0] = "dhaka";
names[1] = "sylhet";

string[] names2 = new string[] { "dhaka", "Sylhet" };
string[] names3 = ["dhaka", "sylhet"];
string[] names4 = {"dhaka", "sylhet"};
int[] ages = {10, 20, 30};



//Multi Dimensional Array
int[,] twoDimensionalArray = new int[3, 3];
int[,,] threeDimensionalArray = new int[3, 3, 3];

int[,] grid4 = new int[,] { { 2, 3 }, { 4, 9 } };



//Jagged Array
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[2];
jaggedArray[1] = new int[6];
jaggedArray[2] = new int[4];

int arrayLength = jaggedArray.GetLength(0);