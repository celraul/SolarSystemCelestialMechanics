import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginModel } from 'src/app/models/login.model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit, OnDestroy {
  formLogin: FormGroup;

  constructor(private formBuilder: FormBuilder, private router: Router) {}

  ngOnInit(): void {
    this.initComponents();
  }

  ngOnDestroy(): void {}

  initComponents() {
    this.initForm();
  }

  initForm() {
    this.formLogin = this.formBuilder.group({
      login: [null, [Validators.required]],
      password: [null, [Validators.required]],
    });
  }

  onSubmitLogin(login: LoginModel) {
    debugger;
    if (!this.formLogin.invalid) {
      this.router.navigate(['/dashboard']);
    } else {
      console.error('erro ao realizar login');
    }
  }

  resetPassword() {}
}
