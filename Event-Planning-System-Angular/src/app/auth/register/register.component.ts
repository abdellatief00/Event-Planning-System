import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { AccountService } from '../../shared/services/account.service';
import { UserRegister } from '../../shared/models/userRegister.model';

import { ButtonModule } from 'primeng/button';
import { CardModule } from 'primeng/card';
import { FloatLabelModule } from 'primeng/floatlabel';
import { InputTextModule } from 'primeng/inputtext';
import { CalendarModule } from 'primeng/calendar';
@Component({
  selector: 'app-register',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, RouterModule, InputTextModule, ButtonModule, FloatLabelModule, CardModule, CalendarModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css',
})
export class RegisterComponent {
  registerForm : FormGroup = new FormGroup({
    firstName : new FormControl ('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
    lastName : new FormControl ('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
    email : new FormControl ('',[Validators.required,Validators.email]),
    // Password must be at least 8 characters long, contain at least one uppercase letter, one number, and one special character'))
    password : new FormControl ('',[Validators.required,Validators.pattern('^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$')]),
    // Passwords must match
    confirmPassword : new FormControl ('',[Validators.required]),
    dob : new FormControl (new Date(),[Validators.required]),
    // phone number must be an egyption phone number
    phoneNumber : new FormControl ('',[Validators.required,Validators.pattern('^(01)[0125][0-9]{8}$')]),
    image : new FormControl ('',[]),
    street : new FormControl ('',[Validators.minLength(3),Validators.maxLength(100)]),
    city : new FormControl ('',[Validators.minLength(3),Validators.maxLength(50)]),
    region : new FormControl ('',[Validators.required])
  })

  firstNameControl = this.registerForm.controls['firstName'];
  lastNameControl = this.registerForm.controls['lastName'];
  emailControl = this.registerForm.controls['email'];
  passwordControl = this.registerForm.controls['password'];
  confirmPasswordControl = this.registerForm.controls['confirmPassword'];
  dobControl = this.registerForm.controls['dob'];
  phoneNumberControl = this.registerForm.controls['phoneNumber'];
  imageControl = this.registerForm.controls['image'];
  streetControl = this.registerForm.controls['address'];
  cityControl = this.registerForm.controls['city'];
  regionControl = this.registerForm.controls['region'];

  constructor(private accountService:AccountService){

  }

  register(){
  }


}
