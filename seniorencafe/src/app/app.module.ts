import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { MusicplayerComponent } from './components/musicplayer/musicplayer.component';
import { AccountComponent } from './components/account/account.component';
import { PlaylistComponent } from './components/playlist/playlist.component';
import { EditUserComponent } from './components/edit-user/edit-user.component';
import { AdminComponent } from './components/admin/admin.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MatDialog, MAT_DIALOG_SCROLL_STRATEGY } from '@angular/material/dialog';
import { Overlay } from '@angular/cdk/overlay';
import { MatDialogModule } from '@angular/material/dialog';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    MusicplayerComponent,
    AccountComponent,
    PlaylistComponent,
    EditUserComponent,
    AdminComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NgbModule,
    MatDialogModule
  ],
  providers: [MatDialog, Overlay,],
  bootstrap: [AppComponent]
})
export class AppModule { }
