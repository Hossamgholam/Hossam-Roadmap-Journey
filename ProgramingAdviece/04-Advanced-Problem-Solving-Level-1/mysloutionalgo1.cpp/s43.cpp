#include<iostream>
#include<string>
#include<cmath>
using namespace std;
struct st_timer{
    int your_second,your_minites,your_hour,your_day;
};
int read_number(string messages){
    int your_number;
    do{

    cout<<messages;cin>>your_number;
    }while(your_number<0);
    return your_number;
}
st_timer calculat_timer(int total_second){
    st_timer your_timer;
    const int seconde_per_day=24*60*60;
    const int seconde_per_hour=60*60;
    const int seconde_per_minite=60;
    int remind=0;

    your_timer.your_day=floor(total_second/seconde_per_day);
    remind=total_second%seconde_per_day;
    your_timer.your_hour=floor(remind/seconde_per_hour);
    remind=total_second%seconde_per_hour;
    your_timer.your_minites=floor(remind/seconde_per_minite);
    remind=total_second%seconde_per_minite;
    your_timer.your_second=remind;
 return your_timer;
}
void print_timer(st_timer your_timer){
    cout<<your_timer.your_day<<":"<<your_timer.your_hour<<":"<<your_timer.your_minites<<":"<<your_timer.your_second<<endl;
}
int main(){
    int total_second=read_number("please inter total second");
    print_timer(calculat_timer(total_second));
}