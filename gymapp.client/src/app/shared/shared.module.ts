import { NgModule } from "@angular/core";
import { MatIconModule } from "@angular/material/icon";
import { MatMenuModule } from "@angular/material/menu";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { MatButtonModule } from "@angular/material/button";

@NgModule({
    exports: [
        BrowserAnimationsModule, MatMenuModule, MatIconModule, NgbModule, MatButtonModule
    ]
})
export class SharedModule { }