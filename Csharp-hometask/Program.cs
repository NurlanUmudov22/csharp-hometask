//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



//Hometask- C# INTRO

//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.



//int n = 21;
//string result = "bolunur";
//string result2 = "bolunmur";
//if (n % 7 == 0 && n % 3 == 0)
//{
//    Console.WriteLine(result);
//}

// else
//{
//    Console.WriteLine(result2 );
//}




//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.


//int n = 22;
//int m = 34;
//int sum = n + m;
//if (n%2 == 0 && m% 2 == 0)
//{
//    int Sum = n + m;

//}
//Console.WriteLine(sum);



//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.


//int n = 19;
//int m = 29;
//int sum = 0; 

//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 1)
//        sum += i;

//}
//Console.WriteLine(sum);



//4) Verilmish arrayin icindeki tek ededlerin cemini tapin.



//    int[] nums = { 3, 5, 2, 4, 8, 7, 16, 5, };
//    int sum = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 == 1)
//    {
//        sum += nums[i];

//    }



//}


//Console.WriteLine(sum);





//5) Verilmish arrayin icindeki cut ededlerin sayini tapin. 




//int[] arr = { 3, 5, 2, 4, 8, 7, 16, 5, 9 };
//int count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        count++;
//    }
//}

//Console.WriteLine(count);




//6) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.



//int n = 34;
//int m = 56;
//int count = 0;

//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 1)
//    {
//        count++;
//    }

//}
//Console.WriteLine(count++);




//7) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.



//int n = 20;
//int m = 30;
//int sum = 0;

//for (int i = 0; i< m; i++)
//{
//    if (i % 2 == 0)
//        sum += i;


//}

//Console.WriteLine(sum);




//8) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.


//int n = 30;
//int m = 51;
//int count = 0;


//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);





//9) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin. 



//int n = 99;
//int count = 0;


//if (n < 2)
//{
//    Console.WriteLine("ne sade, ne murekkeb");
//}

//else if (n == 2)
//{
//    Console.WriteLine("sade");
//}

//for (int i = 1; i < n; i++)
//{
//    if (n % i == 0)
//        count++;
//}

//if (count == 2)
//{
//    Console.WriteLine("sade");
//}
//else
//{
//    Console.WriteLine("murekkeb");
//}


















//Hometask-practise




//int a = 1;
//int b = 100;

//for (int i = a; i <= b; i++)
//{
//    Console.WriteLine(i);
//}





//int a = 1;
//int b = 100;

//for (int i = a; i <= b; i++)
//{
//    if(i%2 == 0)
//    Console.WriteLine(i);
//}



//int a = 1;
//int b = 100;
//int result = 0; 

//for (int i = a; i < b;  i++)
//{
//    if (i % 2 == 0)
//    { 
//        result += i;
//    }

//}
//Console.WriteLine(result);




//string[] arr = { "salam", "sagol", "salam" };

//int count = 0;

//for (int i = 0; i <arr.Length; i++)
//{
//    if (arr[i] == "salam")
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);


//int alfa = 300;
//int beta = 403;
//int sum = alfa + beta;

//Console.WriteLine(sum);



//bool isMarried = true;
// if (isMarried)
//{
//    Console.WriteLine("evlidir");
//}
//else
//{
//    Console.WriteLine("subaydir");
//}


//bool isTechnic = true;
//if (isTechnic)
//{
//    Console.WriteLine("texnikalidir");
//}
//else
//{
//    Console.WriteLine("texnikasizdir");
//}


//int age = 60;

//if ( age > 40)
//{
//    age += 8;
//}
//else 
//        {
//    age -= 16;
//}

//Console.WriteLine(age);





//int t = 14;
//if
//    (t > 20)
//{
//    Console.WriteLine("isti");
//}
//else if
//    (t == 20)
//{
//    Console.WriteLine("normal");
//}
//else
// {
//    Console.WriteLine("soyuq");
//}





//int n = 27;
//if (n % 2 == 1)
//{
//    n += 10;
//}
//else
//{
//    n -= 7;
//}
//Console.WriteLine(n);



//int n = 22;
//int m = 31;
//int sum;
// sum = n + m;
//Console.WriteLine(sum);






//int n = 13;
//int m = 17;
//int sum;
//if (n%2 == 1 && m%2 == 1)
//{
//    sum = n + m;
//    Console.WriteLine(sum);
//}



//int m = 8; 
// while (m < 13)
//{
//    m++;
//    Console.WriteLine(m);

//}





//int v = 13;
//do  
//    {

//        v++;
//        Console.WriteLine(v);
//    }
//while (v < 12) ; 









//tapsiriq 5  +

//int[] arr = { 3, 5, 2, 4, 8, 7, 16, 5, 9 };
//int count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        count++;
//    }
//}

//Console.WriteLine(count);







//tapsiriq 4 +


//    int[] nums = { 3, 5, 2, 4, 8, 7, 16, 5, };
//    int sum = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 == 1)
//    {
//        sum += nums[i];
//    }
//}


//Console.WriteLine(sum);




////tapsiriq 8  +
//int n = 30;
//int m = 51;
//int count = 0;


//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);


//tapsiriq 6  +
//int n = 34;
//int m = 56;
//int count = 0;

//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 1)
//    {
//        count++;
//    }

//}
//Console.WriteLine(count++);


//tapsiriq 2.   +

//int n = 22;
//int m = 34;
//int sum = n + m;
//if (n%2 == 0 && m% 2 == 0)
//{
//    int Sum = n + m;
//}
//Console.WriteLine(sum);




//tapsiriq 1   +


//int n = 21;
//string result = "bolunur";
//string result2 = "bolunmur";
//if (n % 7 == 0 && n % 3 == 0)
//{
//    Console.WriteLine(result);
//}
// else
//{
//    Console.WriteLine(result2 );
//}



//tapsiriq 3


//int n = 19;
//int m = 29;
//int sum = 0; 

//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 1)
//        sum += i;
//}
//Console.WriteLine(sum);



//tapsiriq7.

//int n = 20;
//int m = 30;
//int sum = 0;

//for (int i = 0; i< m; i++)
//{
//    if (i % 2 == 0)
//        sum += i;
//}

//Console.WriteLine(sum);




//int n = 19;
//int m = 23;
//int count = 0;

//for (int i = n; i< m; i++)
//{
//    if (i%2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);





//tapsiriq 9. 

//int n = 99;
//int count = 0;


//if ( n < 2 )
//{
//    Console.WriteLine("ne sade, ne murekkeb");
//}

//else if (n == 2)
//{
//    Console.WriteLine("sade");
//}

//for (int i = 1; i < n; i++)
//{
//    if (n % i == 0)
//        count++;
//}

//if (count == 2)
//{
//    Console.WriteLine("sade");
//}
//else
//{
//    Console.WriteLine("murekkeb");
//}

