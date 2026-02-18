#include<iostream>
#include<iomanip>
#include<ctime>
using namespace std;
/*
random number
full matrix 
print matrix
palindrom matrix

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

bool palindrom(int your_matrix[3][3],int row ,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum/2;y++){
            if(your_matrix[i][y]!=your_matrix[i][colum-y-1]){
                return false;
            }
        }
    }
    return true;
}

int main(){
    int matrix[3][3]={{1,2,1},{2,4,2},{3,2,3}};
    cout<<"this is random number matrix\n";
    //full_matrix(matrix,3,3);
    print_matrix(matrix,3,3);

    if(palindrom(matrix,3,3)){
        cout<<"the matrix is palindrom:";
    }
    else{
        cout<<"the matrix is not palindrom:";
    }
}