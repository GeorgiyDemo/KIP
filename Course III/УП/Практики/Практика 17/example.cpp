#include <iostream>
#include <stdlib.h>
#include <time.h>
#include <stdio.h>

using namespace std;

struct fio{char fam[30]; char imya[30]; char otch[30];};
struct stud {struct fio fio1; char pol; int vozrast; int kurs; char spez[100];};
int main ()
{
	stud stud1;
	int n,i;
	FILE *f;
	char s[20];
	cout<<"imya faila = ";
	cin.getline(s,20);
	f=fopen (s,"wb");
	cout <<"kol-vo studentov= ";
	cin>>n;
	for (i=1;i<=n;i++)
	{
		cout<<"familiya "<<i<<"-go studenta = ";
		cin>>stud1.fio1.fam;
		cout<<"imya "<<i<<"-go studenta = ";
		cin>>stud1.fio1.imya;
		cout<<"otchestvo "<<i<<"-go studenta = ";
		cin>>stud1.fio1.otch;
		cout<<"pol "<<i<<"-go studenta = ";
		cin>>stud1.pol;
		while ((stud1.pol!='m')&&(stud1.pol!='w'))
		{
			cout<<"Pol vveden neverno"<<endl;
			cout<<"pol studenta =";
			cin>>stud1.pol;
		}
		cout<<"vozrast "<<i<<"-go studenta = ";
		cin>>stud1.vozrast;
		cout<<"kurs "<<i<<"-go studenta = ";
		cin>>stud1.kurs;
		cout<<"spez "<<i<<"-go studenta = ";
		cin>>stud1.spez;
		cout<<endl;
		fwrite(&stud1, sizeof(stud),1,f);
	}
	fclose(f);
	return 0;
}
