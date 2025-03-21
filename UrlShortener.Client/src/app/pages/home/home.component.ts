import { Component, signal } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { ShortenerService } from "../../core/services/shortener.service";

@Component({
  selector: "app-home",
  imports: [FormsModule],
  templateUrl: "./home.component.html",
  styleUrl: "./home.component.less",
})
export class HomeComponent {
  url = signal<string>("");
  constructor(readonly shortenerService: ShortenerService) {}

  submitUrl(url: string) {
    url = url.trim();
    this.shortenerService.shortenUrl(url).subscribe((e) => console.log(e));
  }
}
