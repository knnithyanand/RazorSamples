# View Component Basic

## Background

Here’s a quick example Bootstrap form that we will create using View Component.

``` html
<form>
    <div class="form-group">
        <label for="exampleInputEmail1">Email address</label>
        <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
        <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
    </div>

    <div class="form-group">
        <label for="exampleInputPassword1">Password</label>
        <input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">
    </div>

    <div class="form-group form-check">
        <input type="checkbox" class="form-check-input" id="exampleCheck1">
        <label class="form-check-label" for="exampleCheck1">Check me out</label>
    </div>

    <button type="submit" class="btn btn-primary">Submit</button>
</form>
```

The above form contains:

- 1 x Form
- 3 x Form Groups
  - 1 x Input of type Email
  - 1 x Input of type Password
  - 1 x Input of type Checkbox
- 1 x Submit Button

This sample intends to generate a similar form output using a more easy to read Razor syntax markup. The sample mainly focuses on generating HTML in the View and not on form submission.

## Approach

The most redundant part of the form is the `form-group` elements, it makes sense to create Razor View Component for this element. We shall create following View Components:

- Email Field
- Password Field
- Checkbox Field

Our Razor markup should look something like:

``` html
<form>
    <email-field    for="exampleInputEmail1"
                    label="Email address"
                    placeholder="user@example.com"
                    hint="We'll never share your email with anyone else." />

    <password-field for="exampleInputPassword1"
                    label="Password"
                    placeholder="Your secure password" />

    <checkbox-field for="exampleCheck1"
                    label="Check me out" />

    <button type="submit" class="btn btn-primary">Submit</button>
</form>
```
