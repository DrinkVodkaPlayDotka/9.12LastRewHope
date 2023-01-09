Stack L1 =new Stack();
Stack L2 =new Stack();

//Тест
L1.list = new List<string>() { "1", "2", "3" };  
L2.list = new List<string>() { "6", "5", "4" };

L1.Merge(L1.list,L2.list);
L1.Print(); 




public class Stack
{
    	
    public List<string> list = new List<string>();
    public void Print()
    {
        for (int i=0 ;i< list.Count;i++)
        {
            Console.WriteLine(list[i]);
        }
    }
    public void Add(string bukv)
    {
        list.Add(bukv);
    }
    public void Pop()
    {
        try{
            list.RemoveAt(list.Count-1);
        }
        catch(Exception)
        {
            Console.WriteLine("Стек пустой");
        }
    }
    public void Size()
    {
        Console.WriteLine(list.Count);
    }
    public void Top()
    {
        try
        {
        Console.WriteLine(list[list.Count-1]);
        }
        catch (Exception)
        {
            Console.WriteLine("0");
        }
    }
}
public static class StackExtensions 
{
    public static List<string> Merge (this Stack stack,List<string> s1,List<string> s2)
    {
        s2.Reverse();
        
        for (int i=0;i<s2.Count;i++)
        {
            s1.Add(s2[i]);
        }
        return s1;
    }
}
