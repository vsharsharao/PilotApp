import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../_service/auth.service';
import { AlertifyService } from '../_service/alertify.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss'],
})
export class RegisterComponent implements OnInit {
  model: any = {};
  @Output() registrationCancel = new EventEmitter<boolean>();

  constructor(private auth: AuthService, private alertify: AlertifyService) {}

  ngOnInit() {}

  register() {
    this.auth.register(this.model).subscribe(
      () => {
        this.alertify.success('Registered successfully');
      },
      error => {
        this.alertify.error(error);
      }
    );
  }

  cancel() {
    this.registrationCancel.emit(true);
  }
}
