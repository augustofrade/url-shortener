import { Routes } from "@angular/router";
import { HomeComponent } from "./pages/home/home.component";
import { DefaultLayoutComponent } from "./shared/layouts/default-layout/default-layout.component";

export const routes: Routes = [
  {
    path: "",
    component: DefaultLayoutComponent,
    children: [
      {
        path: "",
        component: HomeComponent,
      },
    ],
  },
];
