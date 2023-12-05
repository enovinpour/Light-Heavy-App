import { NgModule } from "@angular/core";
import { SharedModule } from "../shared/shared.module";
import { BlogComponent } from "./components/blog/blog.component";
import { StoreSectionComponent } from "./components/store-section/store-section.component";
import { HomeComponent } from "./home.component";

@NgModule({
    declarations: [
        HomeComponent,
        BlogComponent,
        StoreSectionComponent
            ],
    imports: [SharedModule],
  })
  export class HomeModule { }