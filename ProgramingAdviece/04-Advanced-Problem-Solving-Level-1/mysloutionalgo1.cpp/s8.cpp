#include<iostream>
using namespace std;
/*
enum {pass=1,fali=2}
function read marke
function check if marke >=50
function print pass or falie;
*/

enum enpass_fail{pass=1,fail=2};
int read_mark(){
    int your_marke;
    cout<<"please inter your marke:";cin>>your_marke;
    return your_marke;
}
enpass_fail check_marke(int your_marke){
    if(your_marke>=50)
    return enpass_fail::pass;
    else
    return enpass_fail::fail;

}
void print_pass_falie(enpass_fail result_of_check){
     if(result_of_check==enpass_fail::pass){
         cout<<"you are pass\n";
     }
     else
         cout<<"you are fail\n";
}
int main(){
    print_pass_falie(check_marke(read_mark()));
}