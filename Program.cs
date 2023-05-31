// See https://aka.ms/new-console-template for more information





string metin = "abcçdefgğhıijklmnoöprsştuüvyz";

for (int i = 0;i < metin.Length; i++)
{
    Console.WriteLine(metin[i] + "-" + metin[i].ToString().ToUpper()+" ");
}
