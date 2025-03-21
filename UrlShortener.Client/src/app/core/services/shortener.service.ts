import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "../../../environments/environment";
import { ApiResponse } from "../types/api-response.type";

@Injectable({
  providedIn: "root",
})
export class ShortenerService {
  private readonly baseUrl = environment.baseApiUrl;

  constructor(private httpClient: HttpClient) {}

  public shortenUrl(url: string) {
    return this.httpClient.post<ApiResponse>(`${this.baseUrl}/shortener`, {
      url,
    });
  }
}
