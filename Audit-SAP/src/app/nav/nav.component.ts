import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalService, BsModalRef } from 'ngx-bootstrap';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};
  modalRef: BsModalRef;
  constructor( public authService: AuthService, private modalService: BsModalService,
    private alertify: AlertifyService, private router: Router) { }

  ngOnInit() {
    console.log(this.authService.decodedToken.unique_name);
  }

  login() {
    this.authService.login(this.model).subscribe(next => {
      this.modalRef.hide();
      this.alertify.success('Logged is successfully');
    }, error => {
      this.alertify.error(error);
    }, () => {
      this.router.navigate(['/home']);
    });
  }

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  loggedIn() {
    return this.authService.loggedIn();
  }

  logout() {
    localStorage.removeItem('token');
    localStorage.removeItem('user');
    this.authService.decodedToken = null;
    this.authService.currentUser = null;
    this.alertify.message('Logged out');
    this.router.navigate(['/home']);
  }

}
