import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "../../../environments/environment";
import { ApiResponse } from "../types/api-response.type";
import { ShortUrlRedirection } from "../types/short-url-redirection.interface";

@Injectable({
  providedIn: "root",
})
export class ShortUrlService {
  private readonly baseUrl = environment.baseApiUrl;

  constructor(private httpClient: HttpClient) {}

  public getOriginalUrl(urlCode: string) {
    return this.httpClient.get<ApiResponse<ShortUrlRedirection>>(
      `${this.baseUrl}/short-url/url/${urlCode}`
    );
  }
}
