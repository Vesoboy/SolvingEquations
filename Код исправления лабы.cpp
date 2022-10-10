#include <iostream>
#include <string>
#include <algorithm>
#include <cmath>
#include <cstdio>
#include <vector>

using namespace std;
	/*
	---------search_for_match---------
	@param -(char) input_char
	‘ункци€ search_for_match возвращает совпадени€ в алфавите
	----------------------------------
	*/
long search_for_match (char input_char)
{
string alf_ang="qwertyuiopasdfghjklzxcvbnm",alf_ANG="QWERTYUIOPASDFGHJKLZXCVBNM";

long one_alf = alf_ang.find(input_char);
long two_alf = alf_ANG.find(input_char);

return max(one_alf, two_alf);
}

int main()
{
	/*
	ќбъ€вление переменных
	
	one_char - перва€ вводима€ строка
	two_char - втора€ вводима€ строка
	mas_alf1 - массив дл€ хранени€ кол-ва вхождени€ символов из алфавита в строке (one_char) 
	mas_alf2 - массив дл€ хранени€ кол-ва вхождени€ символов из алфавита в строке (two_char)  
	*/

string yes="Yes",no="No", one_char,two_char;
long mas_alf1[26],mas_alf2[26],i;

for(i=0;i<26;i++)
{
mas_alf1 [i]=0;
mas_alf2 [i]=0;
}

cin>>one_char>>two_char;

	/*
	----------------------------------
	÷икл провер€ющий посимвольно на совпадени€ в алфавите
	----------------------------------
	*/
for(i=0;i<one_char.size();i++)
    mas_alf1[search_for_match(one_char[i])]++;


for(i=0;i<two_char.size();i++)
	mas_alf2[search_for_match(two_char[i])]++;
		

for(i=0;i<26;i++)
    if((mas_alf1[i]>0)&&(mas_alf2[i]>0))
        {
			cout<<yes<<"\n";
			return 0;

		}
	cout<<no<<"\n";

}
