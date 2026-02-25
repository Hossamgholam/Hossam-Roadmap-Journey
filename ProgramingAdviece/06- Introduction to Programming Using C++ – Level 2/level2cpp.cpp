#include<iostream>
#include"inputlib.h";
#include"output.h";
#include"cmathe.h";
#include "string.h"
#pragma warning(disable:4996)
#include<iomanip>
#include<vector>

#include<fstream>
#include<ctime>
using namespace std;

void write_file(string your_file) {
	fstream employee_name;
	employee_name.open(your_file, ios::out );
	if (employee_name.is_open()) {
		employee_name << "_________|_____________________________|_________\n";
		employee_name << "  code   |            name             |  degree   \n";
		employee_name << "_________|_____________________________|_________\n";
		employee_name << setw(9) << "is33412" << "|" << setw(29) << "computer information system" << "|" << setw(9) << "90" << "|"<<endl;
		employee_name << setw(9) << "cs12" << "|" << setw(29) << "computer sience" << "|" << setw(9) << "90" << "|"<<endl;
		employee_name << setw(9) << "it3412" << "|" << setw(29) << "it" << "|" << setw(9) << "90" << "|"<<endl<<endl;
		employee_name.close();
	}
}
void write_file2(string your_file) {
	fstream my_file;
	my_file.open(your_file, ios::out|ios::app );
	if (my_file.is_open()) {
		my_file << "hossam\n";
		my_file << "ali\n";
		my_file << "mahomed\n";
		my_file.close();
	}
}

void lodedatafromfiletovector(string your_file, vector<string>& your_vector) {
	fstream employee_name;
	employee_name.open(your_file, ios::in);
	if (employee_name.is_open()) {
		string line;
		while (getline(employee_name, line)) {
			your_vector.push_back(line);
		}
		employee_name.close();
	}
}


void savevectortofille(string your_file, vector<string>& your_vector) {
	fstream my_employee;
	my_employee.open(your_file, ios::out);
	if (my_employee.is_open()) {
		for (string& line : your_vector) {
			if (line != "") {

			my_employee << line << endl;
			}
		}
	}
}

void read_file(string your_file) {
	fstream employee_name;
	employee_name.open(your_file, ios::in);
		if (employee_name.is_open()) {
			string line;
			while (getline(employee_name, line)) {
				cout << line << endl;
			}
			employee_name.close();
		}
	
}


void full_vector(vector<string>& your_vector) {
	int size;
	string name;
	cout << "please inter number of employee:"; cin >> size;
	for (int i = 0; i < size; i++) {
		cout << "please inter name of employee:"; cin >> name;
		your_vector.push_back(name);
	}
}
void print_vector(vector<string>& your_vector) {
	vector<string>::iterator itr;
	for (itr = your_vector.begin(); itr < your_vector.end(); itr++) {
		cout << *itr << " ";
	}
}





void fill_to_vector(string your_fill, vector <string>& your_vector) {
	fstream myfill;
	myfill.open(your_fill, ios::in);
	if (myfill.is_open()) {
		string line;
			while (getline(myfill, line)) {
				your_vector.push_back(line);
		}
			myfill.close();
	}
}

void vector_to_fill(string your_fill, vector<string>& your_vector) {
	fstream myfill;
	myfill.open(your_fill, ios::out );
	if (myfill.is_open()) {
		for (string& line : your_vector) {
			if (line != "") {

			myfill << line << endl;
			}
		}

	}
}

void delet_record_fill(string your_fill, string your_recorde) {
	vector<string>my_vector;
	fill_to_vector(your_fill, my_vector);

	
	for (string &line:my_vector) {
		if (line == your_recorde) {
			line = "";
		}
	}

	vector_to_fill(your_fill, my_vector);
}

void print_fill(string your_fill) {
	fstream my_fill;
	my_fill.open(your_fill, ios::in);
	if (my_fill.is_open()) {
		string line;
		while (getline(my_fill, line)) {
			cout << line << endl;
		}
	}
}

void fill_to_vector(string your_fill, vector <string>& your_vector) {
	fstream myfill;
	myfill.open(your_fill, ios::in);
	if (myfill.is_open()) {
		string line;
		while (getline(myfill, line)) {
			your_vector.push_back(line);
		}
		myfill.close();
	}
}

void vector_to_fill(string your_fill, vector<string>& your_vector) {
	fstream myfill;
	myfill.open(your_fill, ios::out);
	if (myfill.is_open()) {
		for (string& line : your_vector) {
			if (line != "") {

				myfill << line << endl;
			}
		}

	}
}

void update_record_fill(string your_fill, string your_recorde,string your_new_record) {
	vector<string>my_vector;
	fill_to_vector(your_fill, my_vector);


	for (string& line : my_vector) {
		if (line == your_recorde) {
			line = your_new_record;
		}
	}

	vector_to_fill(your_fill, my_vector);
}

void print_fill(string your_fill) {
	fstream my_fill;
	my_fill.open(your_fill, ios::in);
	if (my_fill.is_open()) {
		string line;
		while (getline(my_fill, line)) {
			cout << line << endl;
		}
	}
}

int main() {
	time_t t = time(0);

	

	tm* gmtm;
	
	gmtm = localtime(&t);
	cout << "the year from 1900:";cout << gmtm->tm_year << endl;
	cout << "the monthe from start this year:"; cout << gmtm->tm_mon << endl;
	cout << "the day fom starrt this monthe:";cout << gmtm->tm_mday << endl;
	cout << "the hour from start this day:";cout << gmtm->tm_hour << endl;
	cout << "the minute from start this hour:";cout << gmtm->tm_min << endl;
	cout << "the seconde from start this minuter:";cout << gmtm->tm_sec << endl;

	cout << "the day from start this weake:";cout << gmtm->tm_wday << endl;
	cout << "the day from start this year:";cout << gmtm->tm_yday << endl;
	cout << gmtm->tm_isdst;
	

	return 0;
}









