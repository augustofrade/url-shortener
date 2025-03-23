import { Component, inject } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { ShortUrlService } from "../../core/services/short-url.service";
import { ApiResponse } from "../../core/types/api-response.type";
import { ShortUrlRedirection } from "../../core/types/short-url-redirection.interface";

@Component({
  selector: "app-redirection-handler",
  imports: [],
  templateUrl: "./redirection-handler.component.html",
  styleUrl: "./redirection-handler.component.less",
})
export class RedirectionHandlerComponent {
  private readonly activatedRoute = inject(ActivatedRoute);
  private readonly shortUrlService = inject(ShortUrlService);
  validUrl: boolean = true;

  constructor() {
    this.activatedRoute.paramMap.subscribe((params) => {
      const urlCode = params.get("urlCode")!;
      this.shortUrlService
        .getOriginalUrl(urlCode)
        .subscribe((r) => this.handleOriginalUrl(r));
    });
  }

  handleOriginalUrl(response: ApiResponse<ShortUrlRedirection>) {
    if (response.data.shortenedUrl == null) {
      this.validUrl = false;
      return;
    }
    location.href = response.data.shortenedUrl;
  }
}
