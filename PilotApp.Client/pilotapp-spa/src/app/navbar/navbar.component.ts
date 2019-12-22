import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_service/auth.service';
import { AlertifyService } from '../_service/alertify.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss'],
})
export class NavbarComponent implements OnInit {
  constructor(
    public authService: AuthService,
    private alertify: AlertifyService
  ) {}

  model: any = {};

  ngOnInit() {}

  login() {
    this.authService.login(this.model).subscribe(
      data => {
        this.alertify.success('Logged in successfully');
      },
      error => {
        this.alertify.error('Failed to login');
      }
    );
  }

  loggedIn() {
    return this.authService.loggedIn();
  }

  logOut() {
    localStorage.removeItem('token');
    this.alertify.success('Logged out');
  }
}
