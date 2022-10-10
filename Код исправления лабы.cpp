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
	������� search_for_match ���������� ���������� � ��������
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
	���������� ����������
	
	one_char - ������ �������� ������
	two_char - ������ �������� ������
	mas_alf1 - ������ ��� �������� ���-�� ��������� �������� �� �������� � ������ (one_char) 
	mas_alf2 - ������ ��� �������� ���-�� ��������� �������� �� �������� � ������ (two_char)  
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
	���� ����������� ����������� �� ���������� � ��������
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
