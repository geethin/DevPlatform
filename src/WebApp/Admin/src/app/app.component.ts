import { Component } from '@angular/core';
import { OidcSecurityService } from 'angular-auth-oidc-client';
import { Observable, of } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'admin';
  userData$: Observable<any> = of({});
  isAuthenticated = false;

  constructor(
    private oidcSecurityService: OidcSecurityService) {
    console.log('AppComponent STARTING');
  }
  ngOnInit(): void {
    this.userData$ = this.oidcSecurityService.userData$;

    this.oidcSecurityService.checkAuth()
      .subscribe(res => {
        this.isAuthenticated = res.isAuthenticated;
        console.log('app authenticated', res.isAuthenticated);
      });
  }
  login(): void {
    console.log('start login');
    this.oidcSecurityService.authorize();
  }

  logout():void{
    this.oidcSecurityService.logoffAndRevokeTokens().subscribe((result) => console.log(result));
  }
}
