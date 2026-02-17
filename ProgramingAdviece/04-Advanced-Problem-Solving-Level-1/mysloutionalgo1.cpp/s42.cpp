#include<iostream>
#include<cmath>
using namespace std;
float read_number(string messages){
    float your_number;
    cout<<messages;cin>>your_number;
    return your_number;
}
float fn_total_seconde(float your_day,float your_houre,float your_minite,float your_seconde){
    return ((your_day*24*60*60)+(your_houre*60*60)+(your_minite*60)+(your_seconde));
}
int main(){
float day=read_number("please inter number of day:");
float houre=read_number("please inter number of hour:");
float minite=read_number("please inter number of minite:");
float seconde=read_number("please inter number of seconde:");



cout<<"total seconde is:"<<fn_total_seconde(day,houre,minite,seconde);

}