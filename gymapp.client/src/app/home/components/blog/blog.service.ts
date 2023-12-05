import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Article } from "./blog.model";

@Injectable()
export class BlogService {

    constructor(private http: HttpClient) {
    }

    public getNews() {
        return this.http.get<Article[]>("/api/news/getnews");
    }

}