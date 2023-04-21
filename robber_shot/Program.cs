Console.WriteLine("enter no.of robbers:");
int n= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter The Robber with whom Sam will start shooting:");
int shoot= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the gap between the robbers:");
int gap= Convert.ToInt32(Console.ReadLine());
//for (int i = shoot; i <= n; i++) 
while(shoot<=n)
{
    int i = 1;
    Console.WriteLine($"Target = {shoot},  {i} shots completed");
    
    shoot=(shoot+gap+1);

}


