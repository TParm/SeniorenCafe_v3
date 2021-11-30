import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'seniorencafe';
  public isMenuCollapsed = true;
  
  logout(): void {
    window.location.reload();
  }
}
