#include<iostream>
#include<iomanip>
#include<ctime>
#include<cmath>
using namespace std;
/*
random number
full matrix 
print matrix


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



int count(int your_matrix[3][3],int row,int colum){
    int counter=0;
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            if(your_matrix[i][y]==0){
                counter++;
            }
        }
    }
    return counter;
}
bool is_sparse(int matrix[3][3],int row,int colum){
    int size_matrix=row*colum;
    int count_zero=count(matrix,3,3);

    if(count_zero>=ceil(float(size_matrix/2))){
        return true;
    }
    else{
        return false;
    }
}
int main(){
    int matrix[3][3]={{9,0,0},{0,9,2},{3,3,9}};
    //full_matrix(matrix,3,3);
    cout<<"this is matrix\n";
    print_matrix(matrix,3,3);

    if(is_sparse(matrix,3,3)){
        cout<<"the matrix is sparse\n";
    }
    else{
        cout<<"not sparse\n";
    }

}
