#include<iostream>
#include<iomanip>
#include<ctime>
using namespace std;
/*
random number
full matrix 
print matrix
check 1 
check 0
check condation

*/
int random_number(int your_from,int your_to){
    return rand()%(your_to-your_from+1)+your_from;
}
void full_matrix(int your_matrix[3][3],int row ,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            your_matrix[i][y]=random_number(1,10);
        }
    }
}

void print_matrix(int your_matrix[3][3],int row ,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
        
            printf("%0*d\t",2,your_matrix[i][y]);
        }
        cout<<endl;
    }
}
bool check1(int your_matrix[3][3],int row ,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
           if(i==y){
            if(your_matrix[i][y]!=1){
                return false;
            }
           }
        }
    }
    return true;
}
bool check0(int your_matrix[3][3],int row ,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
           if(i!=y){
            if(your_matrix[i][y]!=0){
                return false;
            }
           }
        }
    }
    return true;
}
bool check_condation(int your_matrix[3][3]){
    bool condation1=check1(your_matrix,3,3);
    bool condation2=check0(your_matrix,3,3);
    if(condation1&&condation2==true){
        return true;
    }
    else{
        return false;
    }
}
bool indenty_matrix(int your_matrix[3][3],int row, int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            if(i==y&&your_matrix[i][y]!=1){
                return false;
            }
            else if(i!=y&&your_matrix[i][y]!=0){
                return false;
            }
        }
    }
    return true;
}
int main(){
    int matrix[3][3]={{1,0,0},{0,1,0},{0,0,1}};
    //full_matrix(matrix,3,3);
    cout<<"this is matrix\n";
    print_matrix(matrix,3,3);

    if(indenty_matrix(matrix,3,3)){
        cout<<"the matrix is indenty\n";
    }
    else{
        cout<<"the matrix not indenty\n";
    }
}