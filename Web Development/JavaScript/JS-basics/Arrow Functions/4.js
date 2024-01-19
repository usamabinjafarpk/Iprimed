function fn(f1, f2) {
    console.log(f1());
    console.log(f2());
}
function a() {
    return "Hello Learners";
}
function b() {
    return "Happy To See You Guys";
}
fn(a, b);
fn(
    function () {
        return "Hello";
    },
    function () {
        return "Heyyyiii";
    }
);
