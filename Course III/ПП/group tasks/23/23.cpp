/*
Описать класс с именем WORKER, содержащую следующие поля: 
• фамилия работника;
• название занимаемой должности; 
• год поступления на работу. 
Написать программу, выполняющую следующие действия: ввод с клавиатуры из файла данных в массив, состоящий из двух элементов типа WORKER; вывод на дисплей и в файл данных обо всех работниках. Файловый ввод вывод выполнить в стиле С и С++ Обработать исключение, если файл не открывается
*/

#include <fstream>
#include <iostream>
using namespace std;

class Worker {
    string name;
    string jobname;
    string year;

public:
    Worker(string name, string jobname, string year)
    {
        this->jobname = jobname;
        this->name = name;
        this->year = year;
    }
    void PrintData()
    {
        cout << "Name=" << name << "\n";
        cout << "Jobname=" << jobname << "\n";
        cout << "Year=" << year << "\n";
    }
    string GetYear()
    {
        return year;
    }
    string GetJobName()
    {
        return jobname;
    }
    string GetName()
    {
        return name;
    }
};
struct TagInfo {
    string inner;
    int lastpos;
};
TagInfo GetTagInner(string opentag, string closetag, string code, int pos = 0)
{
    TagInfo tmp;
    int startpos = code.find(opentag, pos);
    int lastpos = code.find(closetag, pos);
    tmp.lastpos = lastpos + closetag.length();
    tmp.inner = code.substr(startpos + opentag.length(), lastpos - startpos - opentag.length());
    return tmp;
}
int main()
{
    Worker* arr[2];
    for (int i = 0; i <= 2; i++) {
        string name, jobname, year;
        cout << "arr[" << i << "]\n";
        cout << "Name=";
        cin >> name;
        cout << "Jobname=";
        cin >> jobname;
        cout << "Year=";
        cin >> year;
        arr[i] = new Worker(name, jobname, year);
    }
    cout << "Writing to file\n";
    ofstream outfile;
    outfile.open("afile.dat");
    for (int i = 0; i <= 2; i++) {
        outfile << "<project><name>" << arr[i]->GetName() << "</name><jobname>" << arr[i]->GetJobName() << "</jobname><year>" << arr[i]->GetYear() << "</year></project>";
    }
    outfile.close();
    cout << "Clearing array\n";
    for (int i = 0; i <= 2; i++) {
        arr[i] = 0;
    }
    cout << "Reading file\n";
    string data;
    ifstream infile;
    infile.open("afile.dat");
    infile >> data;
    infile.close();
    cout << "XML: \n" << data << "\n\n";
    int lastpos = 0;
    for (int i = 0; i <= 2; i++) {
        TagInfo tmp = GetTagInner("<project>", "</project>", data, lastpos);
        arr[i] = new Worker(GetTagInner("<name>", "</name>", tmp.inner).inner, GetTagInner("<jobname>", "</jobname>", tmp.inner).inner, GetTagInner("<year>", "</year>", tmp.inner).inner);
        lastpos = tmp.lastpos;
        cout << lastpos;
        arr[i]->PrintData();
    }
    return 0;
}
