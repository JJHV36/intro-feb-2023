import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { StatusResponseModel } from "../models/status.model";

@Injectable()
export class StatusDataService {
    constructor(private client: HttpClient) { }

    getStatus() {
        return this.client.get<StatusResponseModel>('http://localhost:1337/status');
    }
}