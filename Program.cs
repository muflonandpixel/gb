string[] input = {"Машина", "Робот", "Кот", "р"};
string[] resarray(string[] input){
    int count = 0;
    foreach (string i in input){
        if (i.Length <=3){
            count++;
        }
    }
    string[] res = new string[count];
    int index = 0;
    foreach (string i in input){
        if (i.Length <=3){
            res[index]=i;
            index++;
        }
    }
    return res;
}
string[] res=resarray(input);
Console.WriteLine($"[ {string.Join(", ", input)} ]");
Console.WriteLine($"[ {string.Join(", ", res)} ]");