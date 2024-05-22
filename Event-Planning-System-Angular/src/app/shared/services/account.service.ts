import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UserLogin } from '../models/userLogin.model';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl = 'https://localhost:5001/api/';
  isLoggedIn : boolean = false;

  constructor(private http:HttpClient) { 

  }

  login(user:UserLogin){
    this.http.post(this.baseUrl + 'account/login',user).subscribe({next: (response:any) => {
      console.log(response);
      if(response){
        this.isLoggedIn = true;
        localStorage.setItem('token',response);
      }
    },error: (error:any) => {
      console.log(error);
    }})
  }

  logout(){
    this.isLoggedIn = false;
  }


}
