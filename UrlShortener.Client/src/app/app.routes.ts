import { Routes } from "@angular/router";
import { HomeComponent } from "./pages/home/home.component";
import { RedirectionHandlerComponent } from "./pages/redirection-handler/redirection-handler.component";
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
      {
        path: ":urlCode",
        component: RedirectionHandlerComponent,
      },
    ],
  },
];
